﻿using CineBack.Datos.Interfaz;
using CineBack.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBack.Datos.Implementacion
{
    public class FuncionDao : IFuncionDao
    {
        public bool ButacasDisponibles(int id_funcion, int cantidad)
        {
            bool verificacion = false;
            DataTable tabla = HelperDao.GetInstancia().ConsultarConParam("SP_ESTADOS_BUTACA", new Parametro("@funcion", id_funcion));
            int cantDisponible = 48 - tabla.Rows.Count;
            if (cantidad <= cantDisponible)
            {
                verificacion = true;
            }
            return verificacion;
        }

        public bool ConfirmarNuevaFuncion(Funcion oFuncion)
        {
            bool resultado = true;
            SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-KLE7FAD\\SQLEXPRESS;Initial Catalog=Cine2_0;Integrated Security=True");
            SqlTransaction t = null;
            try
            {
                conexion.Open();
                t = conexion.BeginTransaction();
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion;
                comando.Transaction = t;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "SP_INSERTAR_MAESTRO";
                comando.Parameters.AddWithValue("@dia", oFuncion.Dia);
                comando.Parameters.AddWithValue("@hora", oFuncion.Hora);
                comando.Parameters.AddWithValue("@id_sala", oFuncion.oSala);

                SqlParameter parametro = new SqlParameter();
                parametro.ParameterName = "@id_pelicula";
                parametro.SqlDbType = SqlDbType.Int;
                parametro.Direction = ParameterDirection.Output;
                comando.Parameters.Add(parametro);

                comando.ExecuteNonQuery();

                int peliculaNro = (int)parametro.Value;

                SqlCommand cmdDetalle;

                cmdDetalle = new SqlCommand("SP_INSERTAR_DETALLE", conexion, t);
                cmdDetalle.CommandType = CommandType.StoredProcedure;
                cmdDetalle.Parameters.AddWithValue("@id_pelicula", oFuncion.oPelicula.IdPelicula);
                cmdDetalle.Parameters.AddWithValue("@titulo", oFuncion.oPelicula.Titulo);
                cmdDetalle.Parameters.AddWithValue("@genero", oFuncion.oPelicula.Genero);
                cmdDetalle.Parameters.AddWithValue("@director", oFuncion.oPelicula.Director);
                cmdDetalle.Parameters.AddWithValue("@idioma", oFuncion.oPelicula.Idioma);
                cmdDetalle.Parameters.AddWithValue("@duracion", oFuncion.oPelicula.Duracion);
                cmdDetalle.Parameters.AddWithValue("@clasificacion", oFuncion.oPelicula.Clasificacion);

                t.Commit();
            }
            catch
            {
                if (t != null)
                    t.Rollback();
                resultado = false;
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            return resultado;
        }






        public bool ConfirmarVenta(Venta venta)
        {
            bool resultado = true;
            SqlConnection conexion = HelperDao.GetInstancia().ObtenerConexion();
            SqlTransaction t = null;
            try
            {
                conexion.Open();
                t = conexion.BeginTransaction();
                SqlCommand cmdVenta = new SqlCommand();
                cmdVenta.Connection = conexion;
                cmdVenta.Transaction = t;
                cmdVenta.CommandType = CommandType.StoredProcedure;
                cmdVenta.CommandText = "SP_INSERTAR_VENTA";
                cmdVenta.Parameters.AddWithValue("@cliente", venta.Cliente);

                SqlParameter parametro = new SqlParameter();
                parametro.ParameterName = "@id_venta";
                parametro.SqlDbType = SqlDbType.Int;
                parametro.Direction = ParameterDirection.Output;
                cmdVenta.Parameters.Add(parametro);

                cmdVenta.ExecuteNonQuery();

                int id_venta = (int)parametro.Value;

                SqlCommand cmdEntrada;

                foreach (Entrada entrada in venta.lEntradas)
                {
                    cmdEntrada = new SqlCommand("SP_INSERTAR_ENTRADA", conexion, t);
                    cmdEntrada.CommandType = CommandType.StoredProcedure;
                    cmdEntrada.Parameters.AddWithValue("@id_venta", id_venta);
                    cmdEntrada.Parameters.AddWithValue("@id_funcion", entrada.Funcion.FuncionId);
                    cmdEntrada.Parameters.AddWithValue("@id_butaca", entrada.Butaca.NroButaca);
                    cmdEntrada.Parameters.AddWithValue("@pre_unitario", entrada.Precio);
                    cmdEntrada.ExecuteNonQuery();
                }
                t.Commit();
            }
            catch
            {
                if (t != null)
                    t.Rollback();
                resultado = false;
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();
            }

            return resultado;
        }

        public List<Butaca> GetButacas(int id_sala, int id_funcion)
        {
            List<Butaca> lButacas = new List<Butaca>();
            DataTable tablaButacas = HelperDao.GetInstancia().ConsultarConParam("SP_OBTENER_BUTACAS", new Parametro("@id_sala", id_sala));
            DataTable tablaEstados = HelperDao.GetInstancia().ConsultarConParam("SP_ESTADOS_BUTACA", new Parametro("@funcion", id_funcion));
            foreach (DataRow fila in tablaButacas.Rows)
            {
                Butaca b = new Butaca();
                b.NroButaca = int.Parse(fila["id_butaca"].ToString());
                b.FilaCol = fila["numero"].ToString();
                if (tablaEstados.Rows.Count > 0)
                {
                    foreach (DataRow filaEstados in tablaEstados.Rows)
                    {
                        if (b.NroButaca == int.Parse(filaEstados["id_butaca"].ToString()))
                        {
                            b.Estado = Estado.Ocupado;
                        }
                    }
                }
                else
                {
                    b.Estado = Estado.Libre;
                }
                lButacas.Add(b);
            }



            return lButacas;
        }

        public List<Funcion> GetFunciones(int id_pelicula)
        {
            List<Funcion> lFunciones = new List<Funcion>();
            DataTable tabla = HelperDao.GetInstancia().ConsultarConParam("SP_OBTENER_FUNCIONES", new Parametro("@id_pelicula", id_pelicula));
            foreach (DataRow fila in tabla.Rows)
            {
                //Mapeo de funcion
                Sala oSala = new Sala(int.Parse(fila["id_sala"].ToString()), fila["descripcion"].ToString());
                Funcion oFuncion = new Funcion(new Pelicula(), oSala);
                oFuncion.FuncionId = int.Parse(fila["id_funcion"].ToString());
                DateTime dia = DateTime.Parse(fila["dia"].ToString());
                oFuncion.DiaMostrar = dia.ToString(String.Format("M"));
                DateTime hora = DateTime.Parse(fila["hora"].ToString());
                oFuncion.HoraMostrar = hora.ToString("t");
                //Mapeo de Pelicula
                oFuncion.oPelicula.IdPelicula = int.Parse(fila["id_pelicula"].ToString());
                oFuncion.oPelicula.Titulo = fila["titulo"].ToString();
                oFuncion.oPelicula.Genero = fila["genero"].ToString();
                oFuncion.oPelicula.Idioma = fila["idioma"].ToString();
                oFuncion.oPelicula.Duracion = int.Parse(fila["duracion"].ToString());
                oFuncion.oPelicula.Clasificacion = fila["clasificacion"].ToString();

                lFunciones.Add(oFuncion);
            }
            return lFunciones;
        }

        public List<Pelicula> GetPeliculas()
        {
            List<Pelicula> lPeliculas = new List<Pelicula>();
            DataTable tabla = HelperDao.GetInstancia().Consultar("SP_OBTENER_PELICULAS");
            foreach (DataRow fila in tabla.Rows)
            {
                Pelicula oPelicula = new Pelicula();
                oPelicula.IdPelicula = int.Parse(fila["id_pelicula"].ToString());
                oPelicula.Titulo = fila["titulo"].ToString();
                oPelicula.Genero = fila["genero"].ToString();
                oPelicula.Director = fila["director"].ToString();
                oPelicula.Idioma = fila["idioma"].ToString();
                oPelicula.Duracion = int.Parse(fila["duracion"].ToString());
                oPelicula.Clasificacion = fila["clasificacion"].ToString();
                lPeliculas.Add(oPelicula);
            }
            return lPeliculas;
        }
    }
}

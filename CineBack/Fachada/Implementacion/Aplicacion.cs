using CineBack.Datos.Implementacion;
using CineBack.Datos.Interfaz;
using CineBack.Entidades;
using CineBack.Fachada.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBack.Fachada.Implementacion
{
    public class Aplicacion :IAplicacion
    {
        private IFuncionDao dao;

        public Aplicacion() 
        {
            dao = new FuncionDao();
        }

        public bool ButacasDisponibles(int id_funcion, int cantidad)
        {
            return dao.ButacasDisponibles(id_funcion, cantidad);
        }

        public List<Butaca> GetButacas(int id_sala, int id_funcion)
        {
            return dao.GetButacas(id_sala, id_funcion);
        }

        public List<Funcion> GetFunciones(int pelicula)
        {
            return dao.GetFunciones(pelicula);
        }

        public List<Pelicula> GetPeliculas()
        {
            return dao.GetPeliculas();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBack.Datos.Laboratorio
{
    public class Consultas
    {
        public DataTable RisasSinFin()
        {
            DataTable tabla = new DataTable();
            string consulta = "Select Cliente, [Costo Total de Entradas], [Cantidad Entradas] From RisasSinFin";
            tabla = HelperDao.GetInstancia().ConsultarText(consulta);
            return tabla;
        }
    }
}

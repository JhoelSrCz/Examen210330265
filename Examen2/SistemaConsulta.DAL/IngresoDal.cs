using SistemaConsulta.MODELOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaConsulta.DAL
{
    public class IngresoDal
    {
        Ingreso ingreso1 = new Ingreso();   
        public DataTable ListarIngresoDal()
        {
            string consulta = "SELECT INGRESO.IDINGRESO, PROVEEDOR.NOMBRE AS PROVEEDOR, " +
                                "INGRESO.FECHAINGRESO, INGRESO.TOTAL, INGRESO.ESTADO\r\n" +
                                "FROM     INGRESO INNER JOIN\r\n                  " +
                                "PROVEEDOR ON INGRESO.IDPROVEEDOR = PROVEEDOR.IDPROVEEDOR";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
    }
}

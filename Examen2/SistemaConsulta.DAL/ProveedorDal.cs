using SistemaConsulta.MODELOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaConsulta.DAL
{
    public class ProveedorDal
    {
        public DataTable ListarProveedorDal()
        {
            string consulta = "SELECT Proveedor.NOMBRE, SUM(ING.TOTAL) AS TOTAL_INGRESOS\r\nFROM PROVEEDOR \r\nINNER JOIN INGRESO ING ON Proveedor.IDPROVEEDOR = ING.IDPROVEEDOR\r\nGROUP BY Proveedor.NOMBRE;";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
    }
}

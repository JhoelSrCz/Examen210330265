using SistemaConsulta.MODELOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaConsulta.DAL
{
    public class RolDal
    {
        public DataTable ListarRolDal()
        {
            string consulta = "SELECT Producto.NOMBRE, DI.FECHAVENC AS FECHA_DE_VENCIMIENTO\r\nFROM PRODUCTO INNER JOIN \r\n\t\t\t\t\t\tDETALLEING DI ON Producto.IDPRODUCTO = DI.IDPRODUCTO\r\nWHERE DI.FECHAVENC BETWEEN GETDATE() AND DATEADD(MONTH, 3, GETDATE());";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
    }
}

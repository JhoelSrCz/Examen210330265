using SistemaConsulta.MODELOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaConsulta.DAL
{
    public class MarcaDal
    {
        Marca marca1 = new Marca(); 
        public DataTable ListarMarcaDal()
        {
            string consulta = "SELECT Marca.NOMBRE AS MARCA_MAS_VENDIDA, SUM(dv.CANTIDAD) AS TOTAL_VENTAS\r\nFROM MARCA  INNER JOIN \r\n\t\t\tPRODUCTO  ON Marca.IDMARCA = Producto.IDMARCA\r\n\t\t\tINNER JOIN DETALLEVENTA dv ON Producto.IDPRODUCTO = dv.IDPRODUCTO\r\nGROUP BY Marca.NOMBRE\r\nORDER BY total_ventas DESC";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
    }
}

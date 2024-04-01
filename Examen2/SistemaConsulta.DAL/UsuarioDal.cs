using SistemaConsulta.MODELOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SistemaConsulta.DAL
{
    public class UsuarioDal
    {
        public UsuarioDal() { }
        public DataTable ListarUsuarioDal()
        {
            string consulta = "SELECT Usuario.NOMBREUSER AS VENDEDOR, COUNT(DV.IDPRODUCTO) AS CANTIDAD_PRODUCTOS_VENDIDOS\r\n"+
                                    "FROM USUARIO INNER JOIN\r\n"+
                    "VENTA ON Usuario.IDUSUARIO = Venta.IDVENDEDOR\r\n"+
                    "INNER JOIN DETALLEVENTA DV ON Venta.IDVENTA = DV.IDVENTA\r\n"+
                        "GROUP BY Usuario.NOMBREUSER; ";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
    }
}

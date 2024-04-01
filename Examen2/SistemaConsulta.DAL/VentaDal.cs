using SistemaConsulta.MODELOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaConsulta.DAL
{
    public class VentaDal
    {
        Venta venta1 = new Venta();
        public DataTable ListarVentaDal()
        {
            string consulta = "SELECT VENTA.IDVENTA, CLIENTE.TIPOCLIENTE, USUARIO.NOMBREUSER, " +
                                "VENTA.FECHA, VENTA.TOTAL, VENTA.ESTADO\r\n" +
                                "FROM     VENTA INNER JOIN\r\n                  " +
                                "CLIENTE ON VENTA.IDCLIENTE = CLIENTE.IDCLIENTE INNER JOIN\r\n                  " +
                                "USUARIO ON VENTA.IDVENDEDOR = USUARIO.IDUSUARIO";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
    }
}

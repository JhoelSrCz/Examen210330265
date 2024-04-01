using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaConsulta.MODELOS;

namespace SistemaConsulta.DAL
{
    public class PersonaDal
    {
        public DataTable ListarPersonaDal()
        {
            string consulta = "SELECT Persona.NOMBRE, Persona.APELLIDO, SUM(i.TOTAL) AS INGRESOS_GENERADOS\r\nFROM PERSONA INNER JOIN \r\n\t\t\tCLIENTE  ON Persona.IDPERSONA = Cliente.IDPERSONA\r\n\t\t\tINNER JOIN INGRESO i ON Cliente.IDCLIENTE = i.IDPROVEEDOR\r\nGROUP BY Persona.NOMBRE, Persona.APELLIDO;";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
    }
}

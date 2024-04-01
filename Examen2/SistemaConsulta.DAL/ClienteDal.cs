using SistemaConsulta.MODELOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SistemaConsulta.DAL
{
    public class ClienteDal
    {
        public DataTable ListarClienteDal()
        {
            string consulta = "SELECT Cliente.IdCliente, Persona.Nombre, Persona.Apellido\r\n"+
                                "FROM Cliente INNER JOIN\r\n"+
                                "Persona ON Cliente.IdPersona = Persona.IdPersona";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
    }
}

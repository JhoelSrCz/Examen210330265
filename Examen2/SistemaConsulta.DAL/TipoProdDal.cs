using SistemaConsulta.MODELOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaConsulta.DAL
{
    public class TipoProdDal
    {
        TipoProd tipoProd1 = new TipoProd();
        public DataTable ListarTipoProdDal()
        {
            string consulta = "select * from tipoprod";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
    }
}

using SistemaConsulta.MODELOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaConsulta.DAL
{
    public class UsuarioRolDal
    {
        UsuarioRol usuarioRol1 = new UsuarioRol();  
        public DataTable ListarUsuarioRolDal()
        {
            string consulta = "SELECT USUARIOROL.IDUSUARIOROL, (USUARIO.NOMBREUSER +'  /  '+ " +
                                "USUARIO.CONTRASEÑA)USUARIO_Y_CONTRASEÑA, ROL.NOMBRE AS ROL, " +
                                "USUARIOROL.FECHAASIGNA AS FECHA_ASIGNADA, USUARIOROL.ESTADO\r\n" +
                                "FROM     USUARIOROL INNER JOIN\r\n                 " +
                                "USUARIO ON USUARIOROL.IDUSUARIO = USUARIO.IDUSUARIO INNER JOIN\r\n" +
                                "ROL ON USUARIOROL.IDROL = ROL.IDROL";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
    }
}

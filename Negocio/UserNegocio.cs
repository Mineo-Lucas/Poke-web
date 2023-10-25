using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class UserNegocio
    {
        public bool Loguear(Usuario usuario)
        {
            Conexiondatos cone = new Conexiondatos();
            try
            {
                cone.setearconsulta("select Id, Tipo from Usuarios where Usuario = @Usuario AND Contraseña = @Contraseña");
                cone.setearparametros("@Usuario", usuario.User);
                cone.setearparametros("@Contraseña", usuario.Pass);

                cone.ejecutarlectura();
                while (cone.Lector.Read())
                {
                    usuario.Id = (int)cone.Lector["Id"];
                    usuario.TipoUser = ((int)cone.Lector["Tipo"]) == 2 ? TipoUsuario.admin : TipoUsuario.Normal;
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                cone.cerrarconexion();
            }
        }
    }      
}

using Dominio;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
                cone.setearconsulta("select Id, Tipo from Usuarios where Email = @Email AND Contraseña = @Contraseña");
                cone.setearparametros("@Email", usuario.Email);
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
        public int Registrarse(Usuario nuevo)
        {
            Conexiondatos conec = new Conexiondatos();
            try
            {
                conec.setearProcedure("RegistrarUsuario");
                conec.setearparametros("@Email", nuevo.Email);
                conec.setearparametros("@Contraseña", nuevo.Pass);
                return conec.EjecutarAccionScalar();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conec.cerrarconexion();
            }
            
        }
        public int modificar(Usuario nuevo)
        {
            Conexiondatos conec = new Conexiondatos();
            try
            {
                conec.setearconsulta("update Usuarios set Nombre=@Nombre,Apellido=@Apellido,ImagenPerfil=@Imagen,FechaNacimiento=@FechaNacimiento where Id=@Id");
                conec.setearparametros("@Nombre", nuevo.Nombre);
                conec.setearparametros("@Apellido", nuevo.Apellido);
                conec.setearparametros("@Imagen", nuevo.UrlImagen);
                conec.setearparametros("@Fecha nacimiento", nuevo.FechaNacimiento);
                conec.setearparametros("@Id", nuevo.Id);
                return conec.EjecutarAccionScalar();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conec.cerrarconexion();
            }

        }
    }      
}

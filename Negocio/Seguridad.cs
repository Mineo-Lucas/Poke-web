using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Seguridad
    {
        public static bool SesionActiva(object user)
        {
            Usuario usuario = user != null ? (Usuario)user : null;
            if(usuario != null && usuario.Id !=0)
            {
                return true;
            }
            else
            {
                return false;
            } 
        }
    }
}

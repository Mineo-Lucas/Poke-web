using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


namespace Negocio
{
    public class ElementosNegocio
    {
        public List<Elementos> Listar()
        {
            List<Elementos> lista = new List<Elementos>();
            Conexiondatos datos = new Conexiondatos();
            try
            {
                datos.setearconsulta("select id, descripcion from ELEMENTOS");
                datos.ejecutarlectura();
                while(datos.Lector.Read())
                {
                    Elementos aux= new Elementos();
                    aux.id = (int)datos.Lector["id"];
                    aux.descripcion = (string)datos.Lector["descripcion"];

                    lista.Add(aux);
                }

                return lista;
            }catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarconexion();
            }

        }
        
        
         
        
        

      








    }

}


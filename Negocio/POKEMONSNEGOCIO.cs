using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;
using System.Net.Configuration;
using System.Security.Cryptography.X509Certificates;
using System.Deployment.Internal;

namespace Negocio

{
    public class POKEMONSNEGOCIO
    {
        public List<POKEMONS> Listar(string id) 
        {
            List<POKEMONS> lista = new List<POKEMONS>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=DESKTOP-E7IU7EN\\SQLEXPRESS; database=POKEDEX_DB;integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select Numero, Nombre,p.Descripcion,p.Id, e.Descripcion tipo,urlimagen,d.Descripcion debilidad, IdDebilidad, IdTipo  from POKEMONS p, ELEMENTOS e, ELEMENTOS d where e.Id=p.IdTipo and p.IdDebilidad=d.Id and p.Activo=1 ";
                comando.Connection = conexion; 
                
                if(id != "")
                {
                    comando.CommandText += " and p.id=" + id;
                }

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    POKEMONS AUX = new POKEMONS();
                    AUX.numero = (int)lector["Numero"];
                    AUX.nombre = (string)lector["Nombre"];
                    AUX.descripcion = (string)lector["Descripcion"];
                    AUX.Id = (int)lector["id"];
                    
                    if (!(lector["urlimagen"] is DBNull)) 
                    AUX.urlimagen = (string)lector["urlimagen"];
                    
                    AUX.Tipo = new Elementos();
                    AUX.Tipo.descripcion = (string)lector["tipo"];
                    AUX.Tipo.id = (int)lector["IdTipo"];
                    AUX.debilidad=new Elementos();
                    AUX.debilidad.descripcion = (string)lector["debilidad"];
                    AUX.debilidad.id= (int)lector["IdDebilidad"];

                    lista.Add(AUX);
                }

                conexion.Close();
                return lista;
            }


            catch (Exception ex)
            {
                throw ex;
            }
            
            
        }
        public List<POKEMONS> ListarSP()
        {
            List<POKEMONS> lista = new List<POKEMONS>();
            Conexiondatos con = new Conexiondatos();
            try
            {
                con.setearProcedure("ListarPokedex");
                con.ejecutarlectura();
                while (con.Lector.Read())
                {
                    POKEMONS AUX = new POKEMONS();
                    AUX.numero = (int)con.Lector["Numero"];
                    AUX.nombre = (string)con.Lector["Nombre"];
                    AUX.descripcion = (string)con.Lector["Descripcion"];
                    AUX.Id = (int)con.Lector["id"];

                    if (!(con.Lector["urlimagen"] is DBNull))
                        AUX.urlimagen = (string)con.Lector["urlimagen"];

                    AUX.Tipo = new Elementos();
                    AUX.Tipo.descripcion = (string)con.Lector["tipo"];
                    AUX.Tipo.id = (int)con.Lector["IdTipo"];
                    AUX.debilidad = new Elementos();
                    AUX.debilidad.descripcion = (string)con.Lector["debilidad"];
                    AUX.debilidad.id = (int)con.Lector["IdDebilidad"];

                    lista.Add(AUX);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void ingresar(POKEMONS nuevo)
        {
            Conexiondatos datos= new Conexiondatos();
            try
            {
                datos.setearconsulta("insert into POKEMONS(numero, nombre, descripcion,UrlImagen, activo, IdTipo,IdDebilidad) values(" + nuevo.numero + ",'" + nuevo.nombre + "','" + nuevo.descripcion +"','"+nuevo.urlimagen+"',1,@IdTipo,@IdDebilidad) ");
                datos.setearparametros("@IdTipo", nuevo.Tipo.id);
                datos.setearparametros("@IdDebilidad", nuevo.debilidad.id);
                datos.ejecutaraccion();
                

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarconexion();
            }

        }

        public void modificar(POKEMONS pokimons)
        {
            Conexiondatos conexion = new Conexiondatos();
            try
            {
                conexion.setearconsulta("update POKEMONS set Numero=@Numero,Nombre=@Nombre,Descripcion=@Descripcion,UrlImagen=@Url,IdTipo=@IdTipo,IdDebilidad=@IdDebilidad where Id=@Id");
                conexion.setearparametros("@Numero", pokimons.numero);
                conexion.setearparametros("@Nombre", pokimons.nombre);
                conexion.setearparametros("@Descripcion", pokimons.descripcion);
                conexion.setearparametros("@Url", pokimons.urlimagen);
                conexion.setearparametros("@IdTipo", pokimons.Tipo.id);
                conexion.setearparametros("@IdDebilidad", pokimons.debilidad.id);
                conexion.setearparametros("@Id", pokimons.Id);

                conexion.ejecutaraccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.cerrarconexion();
            }



        }
        public void modificarconSP(POKEMONS pokimons)
        {
            Conexiondatos conexion = new Conexiondatos();
            try
            {
                conexion.setearProcedure("StoredModificarPokemon");
                conexion.setearparametros("@Numero", pokimons.numero);
                conexion.setearparametros("@Nombre", pokimons.nombre);
                conexion.setearparametros("@Descripcion", pokimons.descripcion);
                conexion.setearparametros("@Url", pokimons.urlimagen);
                conexion.setearparametros("@IdTipo", pokimons.Tipo.id);
                conexion.setearparametros("@IdDebilidad", pokimons.debilidad.id);
                conexion.setearparametros("@Id", pokimons.Id);

                conexion.ejecutaraccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.cerrarconexion();
            }



        }
        public void eliminar(int id)
        {
            Conexiondatos conec=new Conexiondatos();
            try
            {
                conec.setearconsulta("delete POKEMONS where id=@Id");
                conec.setearparametros("@Id", id);
                conec.ejecutaraccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<POKEMONS> filtrar(string campo, string criterio, string filtroavanzado)
        {
            List<POKEMONS> lista=new List<POKEMONS>();
            Conexiondatos con=new Conexiondatos();
            try
            {
                string consulta = "select Numero, Nombre,p.Descripcion,p.Id, e.Descripcion tipo,urlimagen,d.Descripcion debilidad, IdDebilidad, IdTipo  from POKEMONS p, ELEMENTOS e, ELEMENTOS d where e.Id=p.IdTipo and p.IdDebilidad=d.Id and ";
                try
                {
                    if (campo == "Nombre")
                    {
                        switch (criterio)
                        {
                            case "comienza con":
                                consulta += "Nombre like'" + filtroavanzado+"%'";
                                break;
                            case "termina con":
                                consulta += "Nombre like '%" + filtroavanzado+"'";
                                break;

                            default:
                                consulta += "Nombre like '%"+ filtroavanzado+"%'";
                                break;
                        }
                    }else if(campo == "Tipo")
                    {
                        switch (criterio)
                        {
                            case "comienza con":
                                consulta += "e.Descripcion like'" + filtroavanzado + "%'";
                                break;
                            case "termina con":
                                consulta += "e.Descripcion like '%" + filtroavanzado + "'";
                                break;

                            default:
                                consulta += "e.Descripcion like '%" + filtroavanzado + "%'";
                                break;
                        }
                    }
                    else
                    {
                        switch (criterio)
                        {
                            case "mayor a":
                                consulta += "numero >" + filtroavanzado;
                                break;
                            case "menor a":
                                consulta += "numero <" + filtroavanzado;
                                break;

                            default:
                                consulta += "numero =" + filtroavanzado;
                                break;
                        }
                    }
                }
                catch (Exception ex)
                {

                    throw ex;
                }

                con.setearconsulta(consulta);
                con.ejecutarlectura();
                while (con.Lector.Read())
                {
                    POKEMONS AUX = new POKEMONS();
                    AUX.numero = (int)con.Lector["Numero"];
                    AUX.nombre = (string)con.Lector["Nombre"];
                    AUX.descripcion = (string)con.Lector["Descripcion"];
                    AUX.Id = (int)con.Lector["id"];

                    if (!(con.Lector["urlimagen"] is DBNull))
                        AUX.urlimagen = (string)con.Lector["urlimagen"];

                    AUX.Tipo = new Elementos();
                    AUX.Tipo.descripcion = (string)con.Lector["tipo"];
                    AUX.Tipo.id = (int)con.Lector["IdTipo"];
                    AUX.debilidad = new Elementos();
                    AUX.debilidad.descripcion = (string)con.Lector["debilidad"];
                    AUX.debilidad.id = (int)con.Lector["IdDebilidad"];

                    lista.Add(AUX);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void eliminarlogico(int id)
        {
            Conexiondatos conex =new Conexiondatos();
            try
            {
                conex.setearconsulta("update POKEMONS set activo=0 where Id=@id");
                conex.setearparametros("@id", id);
                conex.ejecutaraccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }
    }
}

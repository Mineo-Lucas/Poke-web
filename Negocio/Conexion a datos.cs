using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace Negocio
{
    public class Conexiondatos
    {
        private SqlConnection Conexion;
        private SqlCommand Comando;
        private SqlDataReader lector;
        public SqlDataReader Lector
        {
            get { return lector; }
        }
        

        public Conexiondatos(){
        Conexion= new SqlConnection("server=DESKTOP-E7IU7EN\\SQLEXPRESS; database=POKEDEX_DB;integrated security=true");
        Comando= new SqlCommand();
    }
        
        
        public void setearconsulta(string consulta)
        {
            Comando.CommandType= System.Data.CommandType.Text;
            Comando.CommandText= consulta;
        }

        public void setearparametros(string nombre, object valor)
        {
            Comando.Parameters.AddWithValue(nombre, valor);
        }
        public void setearProcedure( string sp)
        {
            Comando.CommandType = System.Data.CommandType.StoredProcedure;
            Comando.CommandText= sp;
        }


        public void ejecutarlectura()
        {
            Comando.Connection = Conexion;
            try
            {
                Conexion.Open();
                lector = Comando.ExecuteReader();
            }catch (Exception ex)
            {
                throw ex;
            }

        }

        public void cerrarconexion()
        {
            if (lector != null)
            {
                lector.Close();
                Conexion.Close();
            }
            
        }

        public void ejecutaraccion()
        {
            Comando.Connection= Conexion;

            try
            {
                Conexion.Open();
                Comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public int EjecutarAccionScalar()
        {
            Comando.Connection = Conexion;

            try
            {
                Conexion.Open();
                return int.Parse(Comando.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


    }
}

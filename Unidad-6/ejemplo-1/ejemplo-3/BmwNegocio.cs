using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace ejemplo_3
{
    internal class BmwNegocio
    {
        public List<BMW> listar()
        {
            List<BMW> lista = new List<BMW>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=BMW_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select Marca, Modelo, Año, UrlImagen from LISTA";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while(lector.Read())
                {
                    BMW aux = new BMW();
                    aux.Marca = (string)lector["Marca"];
                    aux.Modelo = (string)lector["Modelo"];
                    aux.Año = (int)lector["Año"];
                    aux.UrlImagen = (string)lector["UrlImagen"];

                    lista.Add(aux);
                }
                conexion.Close();
                return lista;
            }
            catch (Exception error)
            {

                throw error;
            }
        }
    }
}

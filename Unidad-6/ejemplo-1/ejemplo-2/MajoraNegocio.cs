using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace ejemplo_2
{
    internal class MajoraNegocio
    {
        //PASO 2
        public List<Majora> listar()
        {
            List<Majora> lista = new List<Majora>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=MAJORAS_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select Nombre, Descripcion, UrlImagen from INVENTARIO";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Majora aux = new Majora();
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Acceso_a_Datos;


namespace Negocio
{
    public class ElementoNegocio
    {
        public List<Elemento> listar()
        {
            List<Elemento> listaElemento = new List<Elemento>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetConsulta("select Id, Descripcion From ELEMENTOS");
                datos.RunLectura();
                while(datos.Lector.Read())
                {
                    Elemento aux = new Elemento();
                    aux.Numero = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    listaElemento.Add(aux);
                }
                return listaElemento;
            }
            catch (Exception error)
            {

                throw error;
            }
            finally
            {
                datos.CloseConexion();
            }
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acceso_a_Datos;
using Dominio;

namespace Negocio
{
    public class CaracteristicaNegocio
    {
        public List<Marca> listarMarca()
        {
            List<Marca> listaMarca = new List<Marca>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetConsulta("select Id, Descripcion From MARCAS");
                datos.RunLectura();
                while(datos.Lector.Read())
                {
                    Marca aux = new Marca();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    listaMarca.Add(aux);
                }
                return listaMarca;
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
        public List<Categoria> listarCategoria()
        {
            List<Categoria> listaCategoria = new List<Categoria>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetConsulta("select Id, Descripcion From CATEGORIAS");
                datos.RunLectura();
                while (datos.Lector.Read())
                {
                    Categoria aux = new Categoria();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    listaCategoria.Add(aux);
                }
                return listaCategoria;
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

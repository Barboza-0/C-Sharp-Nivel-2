using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Acceso_a_Datos;

namespace Negocio
{
    public class PokemonNegocio
    { 
        public List<Pokemon> listar()
        {
			List<Pokemon> listaPokemon = new List<Pokemon>();
			AccesoDatos datos = new AccesoDatos();
			try
			{
                datos.SetConsulta("select P.Numero, P.Nombre, P.Descripcion, P.UrlImagen, T.Descripcion Tipo, D.Descripcion Debilidad from POKEMONS P, ELEMENTOS T, ELEMENTOS D where P.IdTipo = T.Id and P.IdDebilidad = D.Id");
                datos.RunLectura();
                while(datos.Lector.Read())
                {
                    Pokemon aux = new Pokemon();
                    aux.Numero = (int)datos.Lector["Numero"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    if(!(datos.Lector["UrlImagen"] is DBNull))
                        aux.UrlImagen = (string)datos.Lector["UrlImagen"];
                    aux.Tipo = new Elemento();
                    aux.Tipo.Descripcion = (string)datos.Lector["Tipo"];
                    aux.Debilidad = new Elemento();
                    aux.Debilidad.Descripcion = (string)datos.Lector["Debilidad"];

                    listaPokemon.Add(aux);
                }
				return listaPokemon;
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

        public void agregar(Pokemon nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetConsulta("insert into POKEMONS (Numero, Nombre, Descripcion, UrlImagen, Idtipo, IdDebilidad, Activo) values(" + nuevo.Numero + ",'" + nuevo.Nombre + "', '" + nuevo.Descripcion + "', '" + nuevo.UrlImagen + "', @IdTipo, @IdDebilidad, 1)");
                datos.SetParametro("@IdTipo", nuevo.Tipo.Numero);
                datos.SetParametro("@IdDebilidad", nuevo.Debilidad.Numero);
                datos.RunAccion();
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

        public void modificar(Pokemon modificar)
        {

        }
    }

}

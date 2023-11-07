using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Acceso_a_Datos;

namespace Negocio
{
    public class ArticuloNegocio
    {
        private AccesoDatos datos = new AccesoDatos();
        public List<Articulo> listar()
        {
            List<Articulo> listaArticulo = new List<Articulo>();
            try
            {
                datos.SetConsulta("select A.Codigo, A.Nombre, A.Descripcion, M.Descripcion Marca, A.IdMarca, C.Descripcion Categoria, A.IdCategoria, A.ImagenUrl, A.Precio, A.Id from ARTICULOS A, CATEGORIAS C, MARCAS M where A.IdMarca = M.Id and A.IdCategoria = C.Id");
                datos.RunLectura();
                while(datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Marca = new Marca();
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    aux.Precio = (decimal)datos.Lector["Precio"];

                    listaArticulo.Add(aux);
                }
                return listaArticulo;
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
        public List<Articulo> filtrar(string campo, string criterio, string filtro)
        {
            List<Articulo> lista = new List<Articulo>();
            try
            {
                string consulta = "select A.Codigo, A.Nombre, A.Descripcion, M.Descripcion Marca, A.IdMarca, C.Descripcion Categoria, A.IdCategoria, A.ImagenUrl, A.Precio from ARTICULOS A, CATEGORIAS C, MARCAS M where A.IdMarca = M.Id and A.IdCategoria = C.Id";
                switch(campo)
                {
                    case "Nombre":
                        consulta = "select A.Codigo, A.Nombre, A.Descripcion, M.Descripcion Marca, A.IdMarca, C.Descripcion Categoria, A.IdCategoria, A.ImagenUrl, A.Precio from ARTICULOS A, CATEGORIAS C, MARCAS M where A.IdMarca = M.Id and A.IdCategoria = C.Id and A.Nombre ";
                        switch (criterio)
                        {
                            case "Comienza con":
                                consulta += "like '" + filtro + "%'";
                                break;
                            case "Termina con":
                                consulta += "like '%" + filtro + "'";
                                break;
                            default:
                                consulta += "like '%" + filtro + "%'";
                                break;
                        }
                        break;
                    case "Marca":
                        consulta = "select A.Codigo, A.Nombre, A.Descripcion, M.Descripcion Marca, A.IdMarca, C.Descripcion Categoria, A.IdCategoria, A.ImagenUrl, A.Precio from ARTICULOS A, CATEGORIAS C, MARCAS M where A.IdMarca = M.Id and A.IdCategoria = C.Id and M.Descripcion ";
                        switch (criterio)
                        {
                            case "Comienza con":
                                consulta += "like '" + filtro + "%'";
                                break;
                            case "Termina con":
                                consulta += "like '%" + filtro + "'";
                                break;
                            default:
                                consulta += "like '%" + filtro + "%'";
                                break;
                        }
                        break;
                    default:
                        consulta = "select A.Codigo, A.Nombre, A.Descripcion, M.Descripcion Marca, A.IdMarca, C.Descripcion Categoria, A.IdCategoria, A.ImagenUrl, A.Precio from ARTICULOS A, CATEGORIAS C, MARCAS M where A.IdMarca = M.Id and A.IdCategoria = C.Id and C.Descripcion ";
                        switch (criterio)
                        {
                            case "Comienza con":
                                consulta += "like '" + filtro + "%'";
                                break;
                            case "Termina con":
                                consulta += "like '%" + filtro + "'";
                                break;
                            default:
                                consulta += "like '%" + filtro + "%'";
                                break;
                        }
                        break;
                }
                datos.SetConsulta(consulta);
                datos.RunLectura();
                while(datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Marca = new Marca();
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    aux.Precio = (decimal)datos.Lector["Precio"];

                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception error)
            {
                throw error;
            }
        }
        public void agregar(Articulo nuevo)
        {
            try
            {
                datos.SetConsulta("insert into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) values (@Codigo, @Nombre, @Descripcion, @IdMarca, @IdCategoria, @ImagenUrl, @Precio)");
                datos.SetParametro("@Codigo", nuevo.Codigo);
                datos.SetParametro("@Nombre", nuevo.Nombre);
                datos.SetParametro("@Descripcion", nuevo.Descripcion);
                datos.SetParametro("@IdMarca", nuevo.Marca.Id);
                datos.SetParametro("@IdCategoria", nuevo.Categoria.Id);
                datos.SetParametro("@ImagenUrl", nuevo.ImagenUrl);
                datos.SetParametro("@Precio", nuevo.Precio);
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
        public void modificar(Articulo modificar)
        {
            try
            {
                datos.SetConsulta("update ARTICULOS set Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, IdMarca = @IdMarca, IdCategoria = @IdCategoria, ImagenUrl = @ImagenUrl, Precio = @Precio where Id = @Id");
                datos.SetParametro("@Codigo", modificar.Codigo);
                datos.SetParametro("@Nombre", modificar.Nombre);
                datos.SetParametro("@Descripcion", modificar.Descripcion);
                datos.SetParametro("@IdMarca", modificar.Marca.Id);
                datos.SetParametro("@IdCategoria", modificar.Categoria.Id);
                datos.SetParametro("@ImagenUrl", modificar.ImagenUrl);
                datos.SetParametro("@Precio", modificar.Precio);
                datos.SetParametro("@Id", modificar.Id);

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
        public void eliminar(int eliminar)
        {
            try
            {
                datos.SetConsulta("delete from ARTICULOS where Id = @Id");
                datos.SetParametro("@Id", eliminar);
                datos.RunAccion();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

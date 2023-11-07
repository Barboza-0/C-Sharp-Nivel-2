using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Acceso_a_Datos;
using Dominio;
using Negocio;

namespace Presentacion
{
    public partial class FormAgregar : Form
    {
        private Articulo articulo = null;
        private bool auxiliar = true;
        public FormAgregar()
        {
            InitializeComponent();
            Text = "Agregar";
        }
        public FormAgregar(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar";
        }
        public void cargarImagen(string imagen)
        {
            try
            {
                pbAgregar.SizeMode = PictureBoxSizeMode.Zoom;
                pbAgregar.Load(imagen);
            }
            catch (Exception)
            {
                pbAgregar.SizeMode = PictureBoxSizeMode.CenterImage;
                pbAgregar.Load("https://avatars.mds.yandex.net/i?id=dfcb735fd16a96e869fac89ee101ff778aaa927a-9026072-images-thumbs&n=13");
            }
        }
        private void FormAgregar_Load(object sender, EventArgs e)
        {
            CaracteristicaNegocio caracteristicaNegocio = new CaracteristicaNegocio();
            try
            {
                cbMarca.DataSource = caracteristicaNegocio.listarMarca();
                cbMarca.SelectedIndex = -1;
                cbCategoria.DataSource = caracteristicaNegocio.listarCategoria();
                cbCategoria.SelectedIndex = -1;
                if(articulo != null)
                {
                    tbCodigo.Text = articulo.Codigo;
                    tbNombre.Text = articulo.Nombre;
                    tbDescripcion.Text = articulo.Descripcion;
                    cbMarca.Text = articulo.Marca.Descripcion;
                    cbCategoria.Text = articulo.Categoria.Descripcion;
                    tbImagenUrl.Text = articulo.ImagenUrl;
                    tbPrecio.Text = articulo.Precio.ToString();
                    cargarImagen(articulo.ImagenUrl);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if(articulo == null)
                {
                    articulo = new Articulo();
                }
                articulo.Codigo = tbCodigo.Text;
                if(tbNombre.Text != "")
                {
                    foreach(char character in tbNombre.Text)
                    {
                        if(!(char.IsLetter(character)) && !(char.IsNumber(character)) && !(char.IsSeparator(character)))
                        {
                            auxiliar = false;
                        }
                    }
                    if(auxiliar == true)
                    {
                        articulo.Nombre = tbNombre.Text;
                    }
                    else
                    {
                        auxiliar = true;
                        MessageBox.Show("No ingrese simbolos\r\n *Nombre*", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                articulo.Descripcion = tbDescripcion.Text;
                if(cbMarca.SelectedIndex != -1)
                {
                    articulo.Marca = (Marca)cbMarca.SelectedItem;
                }
                else
                {
                    lbAsterisco4.Visible = true;
                }
                if(cbCategoria.SelectedIndex != -1)
                {
                    articulo.Categoria = (Categoria)cbCategoria.SelectedItem;
                }
                else
                {
                    lbAsterisco5.Visible = true;
                }
                articulo.ImagenUrl = tbImagenUrl.Text;
                if(tbPrecio.Text != "")
                {
                    foreach (char character in tbPrecio.Text)
                    {
                        if(!(char.IsNumber(character)) && !(character == ','))
                        {
                            auxiliar = false;
                        }
                    }
                    if(auxiliar == true)
                    {
                        articulo.Precio = decimal.Parse(tbPrecio.Text);
                    }
                    else
                    {
                        auxiliar = true;
                        MessageBox.Show("Ingrese unicamente números con coma\r\n *Precio*", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if(articulo.Id != 0)
                {
                    if(tbCodigo.Text != "" && tbNombre.Text != "" && tbPrecio.Text != "" && cbMarca.SelectedIndex != -1 && cbCategoria.SelectedIndex != -1)
                    {
                        foreach (char character in tbNombre.Text)
                        {
                            if(!(char.IsLetter(character)) && !(char.IsNumber(character)) && !(char.IsSeparator(character)))
                            {
                                auxiliar = false;
                            }
                        }
                        foreach (char character in tbPrecio.Text)
                        {
                            if(!(char.IsNumber(character)) && !(character == ','))
                            {
                                auxiliar = false;
                            }
                        }
                        if (auxiliar == true)
                        {
                            negocio.modificar(articulo);
                            MessageBox.Show("Modificado exitosamente!", "Articulo modificado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        else
                        {
                            auxiliar = true;
                        }
                    }
                    else
                    {
                        if (tbCodigo.Text == "")
                        {
                            lbAsterisco1.Visible = true;
                        }
                        else
                        {
                            lbAsterisco1.Visible = false;
                        }
                        if (tbNombre.Text == "")
                        {
                            lbAsterisco2.Visible = true;
                        }
                        else
                        {
                            lbAsterisco2.Visible = false;
                        }
                        if (tbPrecio.Text == "")
                        {
                            lbAsterisco3.Visible = true;
                        }
                        else
                        {
                            lbAsterisco3.Visible = false;
                        }
                        if (cbMarca.SelectedIndex != -1)
                        {
                            lbAsterisco4.Visible = false;
                        }
                        if (cbCategoria.SelectedIndex != -1)
                        {
                            lbAsterisco5.Visible = false;
                        }
                    }
                }
                else
                {
                    if(tbCodigo.Text != "" && tbNombre.Text != "" && tbPrecio.Text != "" && cbMarca.SelectedIndex != -1 && cbCategoria.SelectedIndex != -1)
                    {
                        foreach (char character in tbNombre.Text)
                        {
                            if(!(char.IsLetter(character)) && !(char.IsNumber(character)) && !(char.IsSeparator(character)))
                            {
                                auxiliar = false;
                            }
                        }
                        foreach (char character in tbPrecio.Text)
                        {
                            if(!(char.IsNumber(character)) && !(character == ','))
                            {
                                auxiliar = false;
                            }
                        }
                        if(auxiliar == true)
                        {
                            negocio.agregar(articulo);
                            MessageBox.Show("Agregado exitosamente!", "Nuevo articulo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        else
                        {
                            auxiliar = true;
                        }
                    }
                    else
                    {
                        if(tbCodigo.Text == "")
                        {
                            lbAsterisco1.Visible = true;
                        }
                        else
                        {
                            lbAsterisco1.Visible = false;
                        }
                        if(tbNombre.Text == "")
                        {
                            lbAsterisco2.Visible = true;
                        }
                        else
                        {
                            lbAsterisco2.Visible = false;
                        }
                        if (tbPrecio.Text == "")
                        {
                            lbAsterisco3.Visible = true;
                        }
                        else
                        {
                            lbAsterisco3.Visible = false;
                        }
                        if(cbMarca.SelectedIndex != -1)
                        {
                            lbAsterisco4.Visible = false;
                        }
                        if(cbCategoria.SelectedIndex != -1)
                        {
                            lbAsterisco5.Visible = false;
                        }
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void tbImagenUrl_Leave(object sender, EventArgs e)
        {
            cargarImagen(tbImagenUrl.Text);
        }
    }
}

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
    public partial class Presentacion : Form
    {
        private List<Articulo> listaArticulo;
        public Presentacion()
        {
            InitializeComponent();
        }
        public void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulo = negocio.listar();
                dgvArticulo.DataSource = listaArticulo;
                ocultarColumnas();
                cargarImagen(listaArticulo[0].ImagenUrl);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }
        public void cargarImagen(string imagen)
        {
            try
            {
                pbArticulo.SizeMode = PictureBoxSizeMode.Zoom;
                pbArticulo.Load(imagen);
            }
            catch (Exception)
            {
                pbArticulo.SizeMode = PictureBoxSizeMode.CenterImage;
                pbArticulo.Load("https://avatars.mds.yandex.net/i?id=dfcb735fd16a96e869fac89ee101ff778aaa927a-9026072-images-thumbs&n=13");
            }
        }
        public void ocultarColumnas()
        {
            dgvArticulo.Columns["ImagenUrl"].Visible = false;
            dgvArticulo.Columns["Id"].Visible = false;
        }
        public void cargarFiltro()
        {
            cbCampo.Items.Add("Nombre");
            cbCampo.Items.Add("Marca");
            cbCampo.Items.Add("Categoria");
            cbCriterio.Items.Add("Comienza con");
            cbCriterio.Items.Add("Termina con");
            cbCriterio.Items.Add("Contiene");
        }
        private void Presentacion_Load(object sender, EventArgs e)
        {
            cargar();
            cargarFiltro();
        }
        private void dgvArticulo_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvArticulo.CurrentRow != null)
            {
                Articulo selecionado = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;
                cargarImagen(selecionado.ImagenUrl);
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if (cbCampo.SelectedIndex != -1 && cbCriterio.SelectedIndex != -1)
                {
                    string campo = cbCampo.SelectedItem.ToString();
                    string criterio = cbCriterio.SelectedItem.ToString();
                    string filtro = tbFiltro.Text;
                    dgvArticulo.DataSource = negocio.filtrar(campo, criterio, filtro);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAgregar add = new FormAgregar();
            add.ShowDialog();
            cargar();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Articulo seleccionado;
                if(dgvArticulo.CurrentRow != null)
                {
                    seleccionado = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;
                    FormAgregar modificar = new FormAgregar(seleccionado);
                    modificar.ShowDialog();
                    cargar();
                }
                else
                {
                    MessageBox.Show("No hay un articulo seleccionado", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;
            try
            {
                if(dgvArticulo.CurrentRow != null)
                {
                    DialogResult respuesta = MessageBox.Show("¿Desea eliminar este Articulo?", "Atencion!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if(respuesta == DialogResult.Yes)
                    {
                        seleccionado = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;
                        negocio.eliminar(seleccionado.Id);
                        cargar();
                    }
                }
                else
                {
                    MessageBox.Show("No hay un articulo seleccionado", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }
    }
}

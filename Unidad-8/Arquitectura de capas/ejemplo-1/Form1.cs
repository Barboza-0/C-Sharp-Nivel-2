using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace ejemplo_1
{
    public partial class Form1 : Form
    {
        private List<Pokemon> listaPokemon;
        private List<Elemento> listaElemento;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            PokemonNegocio negocio = new PokemonNegocio();
            try
            {
                listaPokemon = negocio.listar();
                dgvPokemon.DataSource = listaPokemon;
                ocultarColumnas();
                cargarImagen(listaPokemon[0].UrlImagen);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        private void ocultarColumnas()
        {
            dgvPokemon.Columns["Numero"].Visible = false;
            dgvPokemon.Columns["UrlImagen"].Visible = false;
        }

        private void dgvPokemon_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPokemon.CurrentRow != null)
            {
                Pokemon seleccionado = (Pokemon)dgvPokemon.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.UrlImagen);
            }
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbPokemon.Load(imagen);
            }
            catch (Exception)
            {
                pbPokemon.Load("https://media.istockphoto.com/id/1147544807/vector/thumbnail-image-vector-graphic.jpg?s=612x612&w=0&k=20&c=rnCKVbdxqkjlcs3xH87-9gocETqpspHFXu5dIGB4wuM=");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAgregar Add = new FormAgregar();
            Add.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Pokemon seleccionado;
            seleccionado = (Pokemon)dgvPokemon.CurrentRow.DataBoundItem;
            FormAgregar Edit = new FormAgregar(seleccionado);
            Edit.ShowDialog();
            cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            PokemonNegocio negocio = new PokemonNegocio();
            Pokemon seleccionado;
            try
            {
                DialogResult ocultar = MessageBox.Show("¿Ocultar del Registro?", "Ocultando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                seleccionado = (Pokemon)dgvPokemon.CurrentRow.DataBoundItem;
                if (ocultar == DialogResult.Yes)
                {
                    negocio.ocultar(seleccionado.Numero);
                    cargar();
                }
                else
                {
                    DialogResult respuesta = MessageBox.Show("¿Eliminar del Registro?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes)
                    {
                        
                        negocio.eliminar(seleccionado.Numero);
                        cargar();
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            List<Pokemon> listfiltro = new List<Pokemon>();
            string filtro = tbBuscar.Text;

            if (filtro.Length >= 3)
            {
                listfiltro = listaPokemon.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Tipo.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listfiltro = listaPokemon;
            }
            dgvPokemon.DataSource = null;
            dgvPokemon.DataSource = listfiltro;
            ocultarColumnas();
        }
    }
}

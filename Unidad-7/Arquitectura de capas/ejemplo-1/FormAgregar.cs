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
    public partial class FormAgregar : Form
    {
        public FormAgregar()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Pokemon nwPokemon = new Pokemon();
            PokemonNegocio negocio = new PokemonNegocio();
            try
            {
                nwPokemon.Numero = int.Parse(tbNumero.Text);
                nwPokemon.Nombre = tbNombre.Text;
                nwPokemon.Descripcion = tbDescripcion.Text;
                nwPokemon.UrlImagen = tbUrlImagen.Text;
                nwPokemon.Tipo = (Elemento)cbTipo.SelectedItem;
                nwPokemon.Debilidad = (Elemento)cbDebilidad.SelectedItem;

                negocio.agregar(nwPokemon);
                MessageBox.Show("Agregado Exitosamente!");
                Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.pokemon.com/el/pokedex");
        }

        private void tbNumero_Enter(object sender, EventArgs e)
        {
            if (tbNumero.Text == "Sin 0's")
            {
                tbNumero.Text = "";
                tbNumero.ForeColor = Color.Black;
            }
        }

        private void tbNumero_Leave(object sender, EventArgs e)
        {
            if (tbNumero.Text == "")
            {
                tbNumero.Text = "Sin 0's";
                tbNumero.ForeColor = Color.Silver;
            }
        }

        private void tbUrlImagen_Enter(object sender, EventArgs e)
        {
            if (tbUrlImagen.Text == "Link")
            {
                tbUrlImagen.Text = "";
                tbUrlImagen.ForeColor = Color.Black;
            }
        }

        private void tbUrlImagen_Leave(object sender, EventArgs e)
        {
            if (tbUrlImagen.Text == "")
            {
                tbUrlImagen.Text = "Link";
                tbUrlImagen.ForeColor = Color.Silver;
            }
            cargarImagen(tbUrlImagen.Text);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbPokenew.Load(imagen);
            }
            catch (Exception)
            {
                pbPokenew.Load("https://media.istockphoto.com/id/1147544807/vector/thumbnail-image-vector-graphic.jpg?s=612x612&w=0&k=20&c=rnCKVbdxqkjlcs3xH87-9gocETqpspHFXu5dIGB4wuM=");
            }
        }

        private void FormAgregar_Load(object sender, EventArgs e)
        {
            ElementoNegocio elementoNegocio = new ElementoNegocio();
            try
            {
                cbTipo.DataSource = elementoNegocio.listar();
                cbDebilidad.DataSource = elementoNegocio.listar();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }
    }
}

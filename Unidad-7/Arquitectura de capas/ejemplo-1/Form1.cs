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
            try
            {
                PokemonNegocio negocio = new PokemonNegocio();
                listaPokemon = negocio.listar();
                dgvPokemon.DataSource = listaPokemon;
                dgvPokemon.Columns["Numero"].Visible = false;
                dgvPokemon.Columns["UrlImagen"].Visible = false;
                cargarImagen(listaPokemon[0].UrlImagen);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        private void dgvPokemon_SelectionChanged(object sender, EventArgs e)
        {
            Pokemon seleccionado = (Pokemon)dgvPokemon.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.UrlImagen);
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
    }
}

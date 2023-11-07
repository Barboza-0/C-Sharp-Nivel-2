using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo_2
{
    //PASO 3
    public partial class Form1 : Form
    {
        private List<Majora> listaMajora;
        public Form1()
        {
            InitializeComponent();
        }

        //PASO 6
        private void Form1_Load(object sender, EventArgs e)
        {
            MajoraNegocio negocio = new MajoraNegocio();
            listaMajora = negocio.listar();
            dataGridView1.DataSource = listaMajora;
            dataGridView1.Columns["UrlImagen"].Visible = false;
            cargarImagen(listaMajora[0].UrlImagen);
        }

        //PASO 5
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            Majora seleccionado = (Majora)dataGridView1.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.UrlImagen);
        }

        //PASO 4
        private void cargarImagen(string imagen)
        {
            try
            {
                pictureBox1.Load(imagen);
            }
            catch (Exception error)
            {
                pictureBox1.Load("https://t3.ftcdn.net/jpg/02/48/42/64/360_F_248426448_NVKLywWqArG2ADUxDq6QprtIzsF82dMF.jpg");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo_3
{
    public partial class Form1 : Form
    {
        private List<BMW> listaBM;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BmwNegocio negocio = new BmwNegocio();
            listaBM = negocio.listar();
            dataGridView1.DataSource = listaBM;
            dataGridView1.Columns["UrlImagen"].Visible = false;
            cargarImagen(listaBM[0].UrlImagen);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            BMW seleccionado = (BMW)dataGridView1.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.UrlImagen);
        }

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

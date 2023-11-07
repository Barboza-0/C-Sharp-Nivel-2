using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se cambió el color de fondo");
            this.BackColor = Color.LightCoral;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            MouseEventArgs click = (MouseEventArgs)e;
            if (click.Button == MouseButtons.Left)
                MessageBox.Show("Boton Izquiedo");
            else if (click.Button == MouseButtons.Right)
                MessageBox.Show("Boton Derecho");
            else if (click.Button == MouseButtons.Middle)
                MessageBox.Show("Boton Medio");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.BackColor = Color.Red;
            }
            else
            {
                textBox1.BackColor = System.Drawing.SystemColors.Control;
            }
            if (textBox2.Text == "")
            {
                textBox2.BackColor = Color.Red;
            }
            else
            {
                textBox2.BackColor = System.Drawing.SystemColors.Control;
            }
            if (textBox3.Text == "")
            {
                textBox3.BackColor = Color.Red;
            }
            else
            {
                textBox3.BackColor = System.Drawing.SystemColors.Control;
            }
            if (textBox4.Text == "")
            {
                textBox4.BackColor = Color.Red;
            }
            else
            {
                textBox4.BackColor = System.Drawing.SystemColors.Control;
            }
            string Apellido = textBox1.Text, Nombre = textBox2.Text, Edad = textBox3.Text, Direccion = textBox4.Text;
            if(textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                textBox5.Text = "Apellido y Nombre: " + Apellido + " " + Nombre + "\r\n" + "Edad: " + Edad + "\r\n" + "Dirección: " + Direccion;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar < 48 ||  e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

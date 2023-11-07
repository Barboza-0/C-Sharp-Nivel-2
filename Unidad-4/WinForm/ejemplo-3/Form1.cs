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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Nombre = txtNombre.Text, Edad = txtEdad.Text;
            listView1.Items.Add(Nombre + " tiene " + Edad + " años");
            txtNombre.Clear(); txtEdad.Clear();
        }
        //Operador Ternario
        //string ejemplo = CheckBox.checked == true ? "si" : "no";
    }
}

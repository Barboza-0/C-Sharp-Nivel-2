using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime fecha1;
            fecha1 = dateTimePicker1.Value;
            MessageBox.Show("La fecha es " + fecha1.ToString("D"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La fecha es " + monthCalendar1.SelectionRange);
        }
    }
}

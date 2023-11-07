using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                if(caja1.Text == "")
                {
                caja1.BackColor = Color.Red;
                }
                else
                {
                caja1.BackColor = System.Drawing.SystemColors.Control;
                }
        }

        private void caja1_KeyPress(object sender, KeyPressEventArgs e)
        {
                if((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                {
                    e.Handled = true;
                }
        }

        private void caja2_Leave(object sender, EventArgs e)
        {
                MessageBox.Show("Tiene " + caja2.Text.Length + " caracteres");
        }
    }
}

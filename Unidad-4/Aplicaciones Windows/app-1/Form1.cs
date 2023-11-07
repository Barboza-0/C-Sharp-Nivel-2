using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_1
{
    public partial class FormApp1 : Form
    {
        public FormApp1()
        {
            InitializeComponent();
        }

        private void FormApp1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenidos a C#");
        }

        private void FormApp1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Chau Chau...");
        }
    }
}

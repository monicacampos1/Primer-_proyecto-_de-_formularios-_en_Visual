using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primer__proyecto__de__formularios__en_Visual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnclik_Click(object sender, EventArgs e)
        {

            lblholamundo.Text = "Cristian Herrera ";
            label1.Text = "Gustavo Cerna  ";
            label2.Text = "Lorena Bemudez ";
            label3.Text = "Fredy Campos ";
            label4.Text = "Ivania Guzman ";
            label5.Text = "Monica Campos ";
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryControlesBasicosReboriRenzo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdAsignar_Click(object sender, EventArgs e)
        {
           
            
            if (optAzul.Checked == true);
            { lblTexto.ForeColor = Color.Blue;
                txtTexto.ForeColor = Color.Blue;
            }

            if (optRojo.Checked == true) ;
            { lblTexto.ForeColor= Color.Red;
              txtTexto.ForeColor= Color.Red;
            }
        }

        private void txtTalleres_CheckedChanged(object sender, EventArgs e)
        { }
            

        private void cmdElegir_Click(object sender, EventArgs e)
        {
            string textoConcatenar = "";

            if (chkTalleres.Checked == true);
            { 
                lblElegir.Text = "Gano 2 a 1";
                textoConcatenar = textoConcatenar + "Gano 2 a 1";

            }

            if (chkBelgrano.Checked == true)
            {
                lblElegir.Text = "No Empataron";
                textoConcatenar = textoConcatenar + "No Empataron";

            }

            if (chkBelgrano.Checked == true)
            {
                lblElegir.Text = "Perdio 2 a 1";
                textoConcatenar = textoConcatenar + "Perdio 2 a 1";

            }

            //agregar un item al combobox - list
            cboAñadir.Items.Add(textoConcatenar);
; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

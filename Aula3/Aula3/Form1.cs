using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula3
{
    public partial class frmPRINCIPAL : Form
    {
        public frmPRINCIPAL()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMENSSAGEM_Click(object sender, EventArgs e)
        {
            txtNOME1.Text = txtNOME.Text;
            txtENDERECO1.Text = txtENDERECO.Text;
            MessageBox.Show("Ola " + txtNOME.Text,"Bem Vindo");

            
        }

        private void btnSAIR_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

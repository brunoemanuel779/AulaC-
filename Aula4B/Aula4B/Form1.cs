using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula4B
{
    public partial class frmprincipal : Form
    {
        public frmprincipal()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int anonasc, anoatual,situacao;
            anonasc = Convert.ToInt32(txtnascimento.Text);
            anoatual = Convert.ToInt32(txtanoatual.Text);
            lblmidade.Text = (anoatual - anonasc).ToString();
            situacao = Convert.ToInt32(lblmidade.Text);
            if ( situacao < 18) {
                lblmsituacao.BackColor = Color.Red;
                lblmsituacao.Text = "Nao pode dirigir";
            }
            else
            {
                lblmsituacao.Text = "Sim pode dirigir" ;
            }
          

        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

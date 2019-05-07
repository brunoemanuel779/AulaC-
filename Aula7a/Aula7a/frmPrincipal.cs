using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula7a
{
    public partial class frmPrincipal : Form
    {

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblmenssagem.Text = "0";
            cmbFrutas.Items.Add("Abacaxi");
            cmbFrutas.Items.Add("Limão");
            cmbFrutas.Items.Add("Amora");

            cmbPreco.Items.Add("3,56");
            cmbPreco.Items.Add("4,56");
            cmbPreco.Items.Add("7,99");
        }

        private void cmbPreco_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbFrutas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int quant;
            if (int.TryParse(txtQuantidade.Text, out quant)== false)
            {
                MessageBox.Show("Quantidade Invalida insira quantidade","Aviso",MessageBoxButtons.OK);
                txtQuantidade.Focus();
                return;
            }
            cmbPreco.SelectedIndex = cmbFrutas.SelectedIndex;
            lstSelcecionados.Items.Add(txtQuantidade.Text + " " + cmbFrutas.Text + " " + cmbPreco.Text);
            lblmenssagem.Text = (  double.Parse(lblmenssagem.Text) + double.Parse(cmbPreco.Text) * int.Parse(txtQuantidade.Text)).ToString();
        }

        private void lstSelcecionados_Click(object sender, EventArgs e)
        {
            lstSelcecionados.Items.RemoveAt(lstSelcecionados.SelectedIndex);
            lstSelcecionados.Refresh();
        }
    }
}

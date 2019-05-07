using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio2a
{
    public partial class frmprincipal : Form
    {
        public frmprincipal()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
          float peso, altura,imc;
            
            peso = Convert.ToSingle(txtpeso.Text);
            altura = Convert.ToSingle(txtaltura.Text);
            
            lblmostraimc.Text = (peso / (altura * altura)).ToString();
            lblmminimo.Text = (18.5 * (altura * altura)).ToString();
            lblmmaximo.Text = (24.99 * (altura * altura)).ToString();
     

        }

        private void lblmminimo_Click(object sender, EventArgs e)
        {

        }
    }
}

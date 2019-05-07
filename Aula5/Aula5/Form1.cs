using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula5
{
    public partial class FrmCombo : Form
    {
        public FrmCombo()
        {
            InitializeComponent();
        }

        private void FrmCombo_Load(object sender, EventArgs e)
        {
           

        }

        private void lblestacoes_Click(object sender, EventArgs e)
        {

        }

        private void cboestacoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblescolhida.Text = cboestacoes.SelectedIndex + "- " + cboestacoes.Text;

            switch(cboestacoes.SelectedIndex)
            {
                case 0: picestacoes.Load("inverno.jpg");
                break;
                case 1: picestacoes.Load("outono.jpg");
                break;
                case 2: picestacoes.Load("primavera.jpg");
                break;
                case 3: picestacoes.Load("verao.jpg");
                break;
                default :
                    picestacoes.Load("verao.jpg");
                break;


            }
        }
    }
}

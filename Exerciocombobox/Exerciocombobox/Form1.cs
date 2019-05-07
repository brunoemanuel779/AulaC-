using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exerciocombobox
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblmostra.Text = cobplaca.SelectedIndex + "- " + cobplaca.Text;

            switch (cobplaca.SelectedIndex)
            {
                case 0: picplaca.Load("gtx1050ti.png");
                    break;
                case 1:
                    picplaca.Load("gtx10603gb.png");
                    break;
                case 2:
                    picplaca.Load("gtx10606gb.png");
                    break;
                case 3:
                    picplaca.Load("gtx1070.png");
                    break;
                case 4:
                    picplaca.Load("gtx1080.png");
                    break;
                default:
                    picplaca.Load("gtx1080.png");
                    break;

            }

            
            

           
        }

    }
}

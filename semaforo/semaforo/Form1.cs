using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace semaforo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnapare_Click(object sender, EventArgs e)
        {
            lblapare.Text = "Atenção Pare";
        }

        private void btncpare_Click(object sender, EventArgs e)
        {
            lblcpare.Text = "Continue Parado";
        }

        private void btnsiga_Click(object sender, EventArgs e)
        {
            lblsiga.Text = "Siga em frente";
        }

        private void btnapare1_MouseMove(object sender, MouseEventArgs e)
        {
            lblpare1.Text = "Atenção Pare";
        }

        private void btncpare2_MouseMove(object sender, MouseEventArgs e)
        {
            lblcpare2.Text = "Continue Parado";
        }

        private void btnsiga2_MouseMove(object sender, MouseEventArgs e)
        {
            lblsiga2.Text = "Siga em frente";
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

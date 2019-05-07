using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaCheckBox
{
    public partial class FrmCheckBox : Form
    {
        public FrmCheckBox()
        {
            InitializeComponent();
        }

        private void chkInteligente_CheckedChanged(object sender, EventArgs e)
        {
            
            if (chkInteligente.Checked)
            {
                lblQualidades.Text = "Escolhido Inteligente";
            }else
            {
                lblQualidades.Text= "";
            }
        }

        private void lblQualidades_Click(object sender, EventArgs e)
        {

        }

        private void chkAmavel_CheckedChanged(object sender, EventArgs e)
        {
            
            if (chkAmavel.Checked)
            {
                lblQualidades.Text = "Escolhido Amavel";
            }
            else
            {
                lblQualidades.Text = "";
            }
        }

        private void chkSabio_CheckedChanged(object sender, EventArgs e)
        {
            
            if (chkSabio.Checked)
            {
                lblQualidades.Text = "Escolhido Sabio";
            }
            else
            {
                lblQualidades.Text = "";
            }
        }

        private void chkPaciente_CheckedChanged(object sender, EventArgs e)
        {
            
            if (chkPaciente.Checked)
            {
                lblQualidades.Text = "Escolhido Paciente";
            }
            else
            {
                lblQualidades.Text = "";
            }
        }

        private void chkTolerante_CheckedChanged(object sender, EventArgs e)
        {
            
            if (chkTolerante.Checked)
            {
                lblQualidades.Text = "Escolhido Tolerante";
            }
            else
            {
                lblQualidades.Text = "";
            }
        }

        private void chkModesto_CheckedChanged(object sender, EventArgs e)
        {
           
            if (chkModesto.Checked)
            {
                lblQualidades.Text = "Escolhido Modesto";
            }
            else
            {
                lblQualidades.Text = "";
            }
        }

        private void chkTranquilo_CheckedChanged(object sender, EventArgs e)
        {
            
            if (chkTranquilo.Checked)
            {
                lblQualidades.Text = "Escolhido Tranquilo";
            }
            else
            {
                lblQualidades.Text = "";
            }
        }

        private void chkCalmo_CheckedChanged(object sender, EventArgs e)
        {
            
            if (chkCalmo.Checked)
            {
                lblQualidades.Text = "Escolhido Calmo";
            }
            else
            {
                lblQualidades.Text = "";
            }
        }

        private void chkComunicativo_CheckedChanged(object sender, EventArgs e)
        {
            
            if (chkComunicativo.Checked)
            {
                lblQualidades.Text = "Escolhido Comunicativo";
            }
            else
            {
                lblQualidades.Text = "";
            }
        }

        private void chkEngracado_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEngracado.Checked)
            {
                lblQualidades.Text = "Escolhido Engraçado";
            }
            else
            {
                lblQualidades.Text = "";
            }
        }

        private void chkBonito_CheckedChanged(object sender, EventArgs e)
        {
           
            if (chkBonito.Checked)
            {
                lblQualidades.Text = "Escolhido Bonito";
            }
            else
            {
                lblQualidades.Text = "";
            }
        }

        private void chkAlegre_CheckedChanged(object sender, EventArgs e)
        {
            
            if (chkAlegre.Checked)
            {
                lblQualidades.Text = "Escolhido Alegre";
            }
            else
            {
                lblQualidades.Text = "";
            }
        }

        private void btnQualidade_Click(object sender, EventArgs e)
        {
            if (chkInteligente.Checked)
                lblTodas.Text += " Inteligente ";

            if (chkAmavel.Checked)
                lblTodas.Text += " Amavel ";

            if (chkSabio.Checked)
                lblTodas.Text += " Sabio ";

            if (chkPaciente.Checked)
                lblTodas.Text += " Paciente ";

            if (chkTolerante.Checked)
                lblTodas.Text += " Tolerante ";

            if (chkModesto.Checked)
                lblTodas.Text += " Modesto ";

            if (chkTranquilo.Checked)
                lblTodas.Text += " Tranquilo ";

            if (chkCalmo.Checked)
                lblTodas.Text += " Calmo ";

            if (chkComunicativo.Checked)
                lblTodas.Text += " Comunicativo ";

            if (chkPaciente.Checked)
                lblTodas.Text += " Paciente ";

            if (chkBonito.Checked)
                lblTodas.Text += " Bonito ";

            if (chkAlegre.Checked)
                lblTodas.Text += " Alegre ";
        }

        private void rbdAzul_CheckedChanged(object sender, EventArgs e)
        {
            lblTodas.BackColor = Color.Blue;
        }

        private void rbdVermelho_CheckedChanged(object sender, EventArgs e)
        {
            lblTodas.BackColor = Color.Red;
        }

        private void rbdAmarelo_CheckedChanged(object sender, EventArgs e)
        {
            lblTodas.BackColor = Color.Green;
            
        }
    }
}

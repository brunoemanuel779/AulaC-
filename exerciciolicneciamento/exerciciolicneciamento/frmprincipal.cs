using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exerciciolicneciamento
{
    public partial class frmprincipal : Form
    {
        public frmprincipal()
        {
            InitializeComponent();
        }

        private void btnverificar_Click(object sender, EventArgs e)
        {
            string placa = txtplaca.Text;
            
          
            lblhorario.Text = "Horario: 7h as 10h e 17h as 20h ";
            // Switch Licencimento
            switch (placa.Substring(txtplaca.TextLength - 1, 1))
            {
                case "1": lbllicenc.Text = "Licenciar Até Abril";
                          lblproibido.Text = "Proibido: Segunda-Feira";
                    break;
                case "2": lbllicenc.Text = "Licenciar Até Maio";
                          lblproibido.Text = "Proibido: Segunda-Feira";
                    break;
                case "3": lbllicenc.Text = "Licenciar Até Junho";
                          lblproibido.Text = "Proibido: Terça-Feira";
                    break;
                case "4": lbllicenc.Text = "Licenciar Até Julho";
                          lblproibido.Text = "Proibido: Terça-Feira";
                    break;
                case "5": lbllicenc.Text = "Licenciar Até Agosto";
                          lblproibido.Text = "Proibido: Quarta-Feira";
                    break;
                case "6": lbllicenc.Text = "Licenciar Até Agosto";
                          lblproibido.Text = "Proibido: Quarta-Feira";
                    break;
                case "7": lbllicenc.Text = "Licenciar Até Setembro";
                          lblproibido.Text = "Proibido: Quinta-Feira";
                    break;
                case "8": lbllicenc.Text = "Licenciar Até Outubro";
                          lblproibido.Text = "Proibido: Quinta-Feira";
                    break;
                case "9": lbllicenc.Text = "Licenciar Até Novembro";
                          lblproibido.Text = "Proibido: Sexta-Feira";
                    break;
                case "0": lbllicenc.Text = "Licenciar Até Dezembro";
                          lblproibido.Text = "Proibido: Sexta-Feira";
                    break;

            }
            }

        private void lblhorario_Click(object sender, EventArgs e)
        {

        }

        private void frmprincipal_Load(object sender, EventArgs e)
        {

        }
    }
}

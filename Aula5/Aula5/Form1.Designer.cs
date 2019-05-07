namespace Aula5
{
    partial class FrmCombo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblestacoes = new System.Windows.Forms.Label();
            this.cboestacoes = new System.Windows.Forms.ComboBox();
            this.lblmsg = new System.Windows.Forms.Label();
            this.lblescolhida = new System.Windows.Forms.Label();
            this.picestacoes = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picestacoes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblestacoes
            // 
            this.lblestacoes.AutoSize = true;
            this.lblestacoes.Location = new System.Drawing.Point(59, 55);
            this.lblestacoes.Name = "lblestacoes";
            this.lblestacoes.Size = new System.Drawing.Size(155, 22);
            this.lblestacoes.TabIndex = 0;
            this.lblestacoes.Text = "Estações do Ano";
            this.lblestacoes.Click += new System.EventHandler(this.lblestacoes_Click);
            // 
            // cboestacoes
            // 
            this.cboestacoes.ForeColor = System.Drawing.Color.Black;
            this.cboestacoes.FormattingEnabled = true;
            this.cboestacoes.Items.AddRange(new object[] {
            "Inverno",
            "Outono",
            "Primavera",
            "Verão"});
            this.cboestacoes.Location = new System.Drawing.Point(234, 47);
            this.cboestacoes.Name = "cboestacoes";
            this.cboestacoes.Size = new System.Drawing.Size(308, 30);
            this.cboestacoes.Sorted = true;
            this.cboestacoes.TabIndex = 1;
            this.cboestacoes.Text = "Qual estação do ano ?";
            this.cboestacoes.SelectedIndexChanged += new System.EventHandler(this.cboestacoes_SelectedIndexChanged);
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.Location = new System.Drawing.Point(59, 104);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(157, 22);
            this.lblmsg.TabIndex = 2;
            this.lblmsg.Text = "Etação Escolhida";
            // 
            // lblescolhida
            // 
            this.lblescolhida.AutoSize = true;
            this.lblescolhida.Location = new System.Drawing.Point(234, 104);
            this.lblescolhida.Name = "lblescolhida";
            this.lblescolhida.Size = new System.Drawing.Size(0, 22);
            this.lblescolhida.TabIndex = 3;
            // 
            // picestacoes
            // 
            this.picestacoes.Location = new System.Drawing.Point(63, 148);
            this.picestacoes.Name = "picestacoes";
            this.picestacoes.Size = new System.Drawing.Size(479, 282);
            this.picestacoes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picestacoes.TabIndex = 4;
            this.picestacoes.TabStop = false;
            // 
            // FrmCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 442);
            this.Controls.Add(this.picestacoes);
            this.Controls.Add(this.lblescolhida);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.cboestacoes);
            this.Controls.Add(this.lblestacoes);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FrmCombo";
            this.Text = "Aprendendo Combobox";
            this.Load += new System.EventHandler(this.FrmCombo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picestacoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblestacoes;
        private System.Windows.Forms.ComboBox cboestacoes;
        private System.Windows.Forms.Label lblmsg;
        private System.Windows.Forms.Label lblescolhida;
        private System.Windows.Forms.PictureBox picestacoes;
    }
}


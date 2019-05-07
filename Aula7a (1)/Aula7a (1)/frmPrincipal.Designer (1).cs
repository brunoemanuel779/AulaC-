namespace Aula7a
{
    partial class frmPrincipal
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
            this.cmbFrutas = new System.Windows.Forms.ComboBox();
            this.cmbPreco = new System.Windows.Forms.ComboBox();
            this.lblmenssagem = new System.Windows.Forms.Label();
            this.lstSelcecionados = new System.Windows.Forms.ListBox();
            this.lblfrutas = new System.Windows.Forms.Label();
            this.lblquant = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbFrutas
            // 
            this.cmbFrutas.FormattingEnabled = true;
            this.cmbFrutas.Location = new System.Drawing.Point(33, 135);
            this.cmbFrutas.Name = "cmbFrutas";
            this.cmbFrutas.Size = new System.Drawing.Size(207, 30);
            this.cmbFrutas.TabIndex = 0;
            this.cmbFrutas.SelectedIndexChanged += new System.EventHandler(this.cmbFrutas_SelectedIndexChanged);
            // 
            // cmbPreco
            // 
            this.cmbPreco.FormattingEnabled = true;
            this.cmbPreco.Location = new System.Drawing.Point(33, 192);
            this.cmbPreco.Name = "cmbPreco";
            this.cmbPreco.Size = new System.Drawing.Size(207, 30);
            this.cmbPreco.TabIndex = 1;
            this.cmbPreco.SelectedIndexChanged += new System.EventHandler(this.cmbPreco_SelectedIndexChanged);
            // 
            // lblmenssagem
            // 
            this.lblmenssagem.AutoSize = true;
            this.lblmenssagem.Location = new System.Drawing.Point(29, 309);
            this.lblmenssagem.Name = "lblmenssagem";
            this.lblmenssagem.Size = new System.Drawing.Size(21, 22);
            this.lblmenssagem.TabIndex = 2;
            this.lblmenssagem.Text = "0";
            // 
            // lstSelcecionados
            // 
            this.lstSelcecionados.FormattingEnabled = true;
            this.lstSelcecionados.ItemHeight = 22;
            this.lstSelcecionados.Location = new System.Drawing.Point(263, 63);
            this.lstSelcecionados.Name = "lstSelcecionados";
            this.lstSelcecionados.Size = new System.Drawing.Size(244, 268);
            this.lstSelcecionados.TabIndex = 3;
            this.lstSelcecionados.Click += new System.EventHandler(this.lstSelcecionados_Click);
            // 
            // lblfrutas
            // 
            this.lblfrutas.AutoSize = true;
            this.lblfrutas.Location = new System.Drawing.Point(291, 29);
            this.lblfrutas.Name = "lblfrutas";
            this.lblfrutas.Size = new System.Drawing.Size(183, 22);
            this.lblfrutas.TabIndex = 4;
            this.lblfrutas.Text = "Frutas Selecionadas";
            // 
            // lblquant
            // 
            this.lblquant.AutoSize = true;
            this.lblquant.Location = new System.Drawing.Point(29, 63);
            this.lblquant.Name = "lblquant";
            this.lblquant.Size = new System.Drawing.Size(112, 22);
            this.lblquant.TabIndex = 5;
            this.lblquant.Text = "Quantidade:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(147, 56);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(100, 29);
            this.txtQuantidade.TabIndex = 6;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 442);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.lblquant);
            this.Controls.Add(this.lblfrutas);
            this.Controls.Add(this.lstSelcecionados);
            this.Controls.Add(this.lblmenssagem);
            this.Controls.Add(this.cmbPreco);
            this.Controls.Add(this.cmbFrutas);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmPrincipal";
            this.Text = "ListBox";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbFrutas;
        private System.Windows.Forms.ComboBox cmbPreco;
        private System.Windows.Forms.Label lblmenssagem;
        private System.Windows.Forms.ListBox lstSelcecionados;
        private System.Windows.Forms.Label lblfrutas;
        private System.Windows.Forms.Label lblquant;
        private System.Windows.Forms.TextBox txtQuantidade;
    }
}


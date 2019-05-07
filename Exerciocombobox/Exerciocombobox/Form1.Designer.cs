namespace Exerciocombobox
{
    partial class FrmPrincipal
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
            this.lblplaca = new System.Windows.Forms.Label();
            this.cobplaca = new System.Windows.Forms.ComboBox();
            this.picplaca = new System.Windows.Forms.PictureBox();
            this.lblescolhida = new System.Windows.Forms.Label();
            this.lblmostra = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picplaca)).BeginInit();
            this.SuspendLayout();
            // 
            // lblplaca
            // 
            this.lblplaca.AutoSize = true;
            this.lblplaca.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblplaca.Location = new System.Drawing.Point(13, 57);
            this.lblplaca.Name = "lblplaca";
            this.lblplaca.Size = new System.Drawing.Size(206, 22);
            this.lblplaca.TabIndex = 0;
            this.lblplaca.Text = "Escolha placa de video";
            // 
            // cobplaca
            // 
            this.cobplaca.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cobplaca.FormattingEnabled = true;
            this.cobplaca.Items.AddRange(new object[] {
            "Gtx 1050 Ti 4 GB",
            "Gtx 1060 3gb",
            "Gtx 1060 6GB",
            "Gtx 1070 8GB",
            "Gtx 1080 8GB"});
            this.cobplaca.Location = new System.Drawing.Point(225, 55);
            this.cobplaca.Name = "cobplaca";
            this.cobplaca.Size = new System.Drawing.Size(430, 24);
            this.cobplaca.TabIndex = 1;
            this.cobplaca.Text = "Qual sua placa ?";
            this.cobplaca.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // picplaca
            // 
            this.picplaca.Location = new System.Drawing.Point(21, 156);
            this.picplaca.Name = "picplaca";
            this.picplaca.Size = new System.Drawing.Size(638, 314);
            this.picplaca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picplaca.TabIndex = 2;
            this.picplaca.TabStop = false;
            // 
            // lblescolhida
            // 
            this.lblescolhida.AutoSize = true;
            this.lblescolhida.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblescolhida.Location = new System.Drawing.Point(17, 107);
            this.lblescolhida.Name = "lblescolhida";
            this.lblescolhida.Size = new System.Drawing.Size(160, 24);
            this.lblescolhida.TabIndex = 3;
            this.lblescolhida.Text = "Placa Escolhida";
            // 
            // lblmostra
            // 
            this.lblmostra.AutoSize = true;
            this.lblmostra.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmostra.Location = new System.Drawing.Point(233, 110);
            this.lblmostra.Name = "lblmostra";
            this.lblmostra.Size = new System.Drawing.Size(0, 24);
            this.lblmostra.TabIndex = 4;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 482);
            this.Controls.Add(this.lblmostra);
            this.Controls.Add(this.lblescolhida);
            this.Controls.Add(this.picplaca);
            this.Controls.Add(this.cobplaca);
            this.Controls.Add(this.lblplaca);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmPrincipal";
            this.Text = "Placa de Video";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picplaca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblplaca;
        private System.Windows.Forms.ComboBox cobplaca;
        private System.Windows.Forms.PictureBox picplaca;
        private System.Windows.Forms.Label lblescolhida;
        private System.Windows.Forms.Label lblmostra;
    }
}


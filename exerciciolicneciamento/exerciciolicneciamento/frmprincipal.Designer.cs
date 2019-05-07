namespace exerciciolicneciamento
{
    partial class frmprincipal
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
            this.txtplaca = new System.Windows.Forms.TextBox();
            this.btnverificar = new System.Windows.Forms.Button();
            this.lblproibido = new System.Windows.Forms.Label();
            this.lblhorario = new System.Windows.Forms.Label();
            this.lbllicenc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblplaca
            // 
            this.lblplaca.AutoSize = true;
            this.lblplaca.Location = new System.Drawing.Point(12, 83);
            this.lblplaca.Name = "lblplaca";
            this.lblplaca.Size = new System.Drawing.Size(61, 24);
            this.lblplaca.TabIndex = 0;
            this.lblplaca.Text = "Placa:";
            // 
            // txtplaca
            // 
            this.txtplaca.Location = new System.Drawing.Point(79, 78);
            this.txtplaca.Name = "txtplaca";
            this.txtplaca.Size = new System.Drawing.Size(317, 29);
            this.txtplaca.TabIndex = 1;
            // 
            // btnverificar
            // 
            this.btnverificar.Location = new System.Drawing.Point(403, 78);
            this.btnverificar.Name = "btnverificar";
            this.btnverificar.Size = new System.Drawing.Size(106, 29);
            this.btnverificar.TabIndex = 2;
            this.btnverificar.Text = "Verificar";
            this.btnverificar.UseVisualStyleBackColor = true;
            this.btnverificar.Click += new System.EventHandler(this.btnverificar_Click);
            // 
            // lblproibido
            // 
            this.lblproibido.AutoSize = true;
            this.lblproibido.Location = new System.Drawing.Point(75, 152);
            this.lblproibido.Name = "lblproibido";
            this.lblproibido.Size = new System.Drawing.Size(85, 24);
            this.lblproibido.TabIndex = 3;
            this.lblproibido.Text = "Proibido:";
            // 
            // lblhorario
            // 
            this.lblhorario.AutoSize = true;
            this.lblhorario.Location = new System.Drawing.Point(75, 209);
            this.lblhorario.Name = "lblhorario";
            this.lblhorario.Size = new System.Drawing.Size(77, 24);
            this.lblhorario.TabIndex = 4;
            this.lblhorario.Text = "Horario:";
            this.lblhorario.Click += new System.EventHandler(this.lblhorario_Click);
            // 
            // lbllicenc
            // 
            this.lbllicenc.AutoSize = true;
            this.lbllicenc.Location = new System.Drawing.Point(75, 264);
            this.lbllicenc.Name = "lbllicenc";
            this.lbllicenc.Size = new System.Drawing.Size(138, 24);
            this.lbllicenc.TabIndex = 5;
            this.lbllicenc.Text = "Licenciamento:";
            // 
            // frmprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 482);
            this.Controls.Add(this.lbllicenc);
            this.Controls.Add(this.lblhorario);
            this.Controls.Add(this.lblproibido);
            this.Controls.Add(this.btnverificar);
            this.Controls.Add(this.txtplaca);
            this.Controls.Add(this.lblplaca);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmprincipal";
            this.Text = "Rodisio";
            this.Load += new System.EventHandler(this.frmprincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblplaca;
        private System.Windows.Forms.TextBox txtplaca;
        private System.Windows.Forms.Button btnverificar;
        private System.Windows.Forms.Label lblproibido;
        private System.Windows.Forms.Label lblhorario;
        private System.Windows.Forms.Label lbllicenc;
    }
}


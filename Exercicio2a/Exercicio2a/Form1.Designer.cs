namespace Exercicio2a
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
            this.lblpeso = new System.Windows.Forms.Label();
            this.txtpeso = new System.Windows.Forms.TextBox();
            this.lblaltura = new System.Windows.Forms.Label();
            this.txtaltura = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.lblimc = new System.Windows.Forms.Label();
            this.lblmostraimc = new System.Windows.Forms.Label();
            this.lblpesoideal = new System.Windows.Forms.Label();
            this.lblminimo = new System.Windows.Forms.Label();
            this.lblmminimo = new System.Windows.Forms.Label();
            this.lblmaximo = new System.Windows.Forms.Label();
            this.lblmmaximo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblpeso
            // 
            this.lblpeso.AutoSize = true;
            this.lblpeso.Location = new System.Drawing.Point(28, 70);
            this.lblpeso.Name = "lblpeso";
            this.lblpeso.Size = new System.Drawing.Size(65, 24);
            this.lblpeso.TabIndex = 0;
            this.lblpeso.Text = "Peso:";
            // 
            // txtpeso
            // 
            this.txtpeso.Location = new System.Drawing.Point(113, 62);
            this.txtpeso.Name = "txtpeso";
            this.txtpeso.Size = new System.Drawing.Size(100, 32);
            this.txtpeso.TabIndex = 1;
            // 
            // lblaltura
            // 
            this.lblaltura.AutoSize = true;
            this.lblaltura.Location = new System.Drawing.Point(32, 123);
            this.lblaltura.Name = "lblaltura";
            this.lblaltura.Size = new System.Drawing.Size(69, 24);
            this.lblaltura.TabIndex = 2;
            this.lblaltura.Text = "Altura:";
            // 
            // txtaltura
            // 
            this.txtaltura.Location = new System.Drawing.Point(113, 115);
            this.txtaltura.Name = "txtaltura";
            this.txtaltura.Size = new System.Drawing.Size(100, 32);
            this.txtaltura.TabIndex = 3;
            this.txtaltura.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(281, 62);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(173, 85);
            this.btncalcular.TabIndex = 4;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // lblimc
            // 
            this.lblimc.AutoSize = true;
            this.lblimc.Location = new System.Drawing.Point(113, 197);
            this.lblimc.Name = "lblimc";
            this.lblimc.Size = new System.Drawing.Size(54, 24);
            this.lblimc.TabIndex = 5;
            this.lblimc.Text = "IMC:";
            // 
            // lblmostraimc
            // 
            this.lblmostraimc.AutoSize = true;
            this.lblmostraimc.Location = new System.Drawing.Point(247, 197);
            this.lblmostraimc.Name = "lblmostraimc";
            this.lblmostraimc.Size = new System.Drawing.Size(0, 24);
            this.lblmostraimc.TabIndex = 6;
            // 
            // lblpesoideal
            // 
            this.lblpesoideal.AutoSize = true;
            this.lblpesoideal.Location = new System.Drawing.Point(113, 257);
            this.lblpesoideal.Name = "lblpesoideal";
            this.lblpesoideal.Size = new System.Drawing.Size(110, 24);
            this.lblpesoideal.TabIndex = 7;
            this.lblpesoideal.Text = "Peso Ideal";
            // 
            // lblminimo
            // 
            this.lblminimo.AutoSize = true;
            this.lblminimo.Location = new System.Drawing.Point(113, 302);
            this.lblminimo.Name = "lblminimo";
            this.lblminimo.Size = new System.Drawing.Size(82, 24);
            this.lblminimo.TabIndex = 8;
            this.lblminimo.Text = "Minimo:";
            // 
            // lblmminimo
            // 
            this.lblmminimo.AutoSize = true;
            this.lblmminimo.Location = new System.Drawing.Point(247, 302);
            this.lblmminimo.Name = "lblmminimo";
            this.lblmminimo.Size = new System.Drawing.Size(0, 24);
            this.lblmminimo.TabIndex = 9;
            this.lblmminimo.Click += new System.EventHandler(this.lblmminimo_Click);
            // 
            // lblmaximo
            // 
            this.lblmaximo.AutoSize = true;
            this.lblmaximo.Location = new System.Drawing.Point(113, 349);
            this.lblmaximo.Name = "lblmaximo";
            this.lblmaximo.Size = new System.Drawing.Size(88, 24);
            this.lblmaximo.TabIndex = 10;
            this.lblmaximo.Text = "Maximo:";
            // 
            // lblmmaximo
            // 
            this.lblmmaximo.AutoSize = true;
            this.lblmmaximo.Location = new System.Drawing.Point(247, 349);
            this.lblmmaximo.Name = "lblmmaximo";
            this.lblmmaximo.Size = new System.Drawing.Size(0, 24);
            this.lblmmaximo.TabIndex = 11;
            // 
            // frmprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 482);
            this.Controls.Add(this.lblmmaximo);
            this.Controls.Add(this.lblmaximo);
            this.Controls.Add(this.lblmminimo);
            this.Controls.Add(this.lblminimo);
            this.Controls.Add(this.lblpesoideal);
            this.Controls.Add(this.lblmostraimc);
            this.Controls.Add(this.lblimc);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtaltura);
            this.Controls.Add(this.lblaltura);
            this.Controls.Add(this.txtpeso);
            this.Controls.Add(this.lblpeso);
            this.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmprincipal";
            this.Text = "Calculo Imc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblpeso;
        private System.Windows.Forms.TextBox txtpeso;
        private System.Windows.Forms.Label lblaltura;
        private System.Windows.Forms.TextBox txtaltura;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label lblimc;
        private System.Windows.Forms.Label lblmostraimc;
        private System.Windows.Forms.Label lblpesoideal;
        private System.Windows.Forms.Label lblminimo;
        private System.Windows.Forms.Label lblmminimo;
        private System.Windows.Forms.Label lblmaximo;
        private System.Windows.Forms.Label lblmmaximo;
    }
}


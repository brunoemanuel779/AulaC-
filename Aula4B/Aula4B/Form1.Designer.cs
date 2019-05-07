namespace Aula4B
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
            this.lblnascimento = new System.Windows.Forms.Label();
            this.txtnascimento = new System.Windows.Forms.TextBox();
            this.lblanoatual = new System.Windows.Forms.Label();
            this.txtanoatual = new System.Windows.Forms.TextBox();
            this.lblidade = new System.Windows.Forms.Label();
            this.lblsituacao = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.lblmidade = new System.Windows.Forms.Label();
            this.lblmsituacao = new System.Windows.Forms.Label();
            this.btnsair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnascimento
            // 
            this.lblnascimento.AutoSize = true;
            this.lblnascimento.Location = new System.Drawing.Point(14, 64);
            this.lblnascimento.Name = "lblnascimento";
            this.lblnascimento.Size = new System.Drawing.Size(168, 24);
            this.lblnascimento.TabIndex = 0;
            this.lblnascimento.Text = "Ano Nascimento:";
            // 
            // txtnascimento
            // 
            this.txtnascimento.Location = new System.Drawing.Point(189, 57);
            this.txtnascimento.Name = "txtnascimento";
            this.txtnascimento.Size = new System.Drawing.Size(254, 32);
            this.txtnascimento.TabIndex = 1;
            // 
            // lblanoatual
            // 
            this.lblanoatual.AutoSize = true;
            this.lblanoatual.Location = new System.Drawing.Point(14, 132);
            this.lblanoatual.Name = "lblanoatual";
            this.lblanoatual.Size = new System.Drawing.Size(103, 24);
            this.lblanoatual.TabIndex = 2;
            this.lblanoatual.Text = "Ano Atual:";
            // 
            // txtanoatual
            // 
            this.txtanoatual.Location = new System.Drawing.Point(189, 124);
            this.txtanoatual.Name = "txtanoatual";
            this.txtanoatual.Size = new System.Drawing.Size(254, 32);
            this.txtanoatual.TabIndex = 3;
            // 
            // lblidade
            // 
            this.lblidade.AutoSize = true;
            this.lblidade.Location = new System.Drawing.Point(14, 211);
            this.lblidade.Name = "lblidade";
            this.lblidade.Size = new System.Drawing.Size(68, 24);
            this.lblidade.TabIndex = 4;
            this.lblidade.Text = "Idade:";
            // 
            // lblsituacao
            // 
            this.lblsituacao.AutoSize = true;
            this.lblsituacao.Location = new System.Drawing.Point(14, 271);
            this.lblsituacao.Name = "lblsituacao";
            this.lblsituacao.Size = new System.Drawing.Size(99, 24);
            this.lblsituacao.TabIndex = 5;
            this.lblsituacao.Text = "Situação:";
            // 
            // btncalcular
            // 
            this.btncalcular.BackColor = System.Drawing.Color.Transparent;
            this.btncalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncalcular.Location = new System.Drawing.Point(189, 345);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(104, 31);
            this.btncalcular.TabIndex = 8;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = false;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // lblmidade
            // 
            this.lblmidade.AutoSize = true;
            this.lblmidade.Location = new System.Drawing.Point(193, 211);
            this.lblmidade.Name = "lblmidade";
            this.lblmidade.Size = new System.Drawing.Size(0, 24);
            this.lblmidade.TabIndex = 9;
            // 
            // lblmsituacao
            // 
            this.lblmsituacao.AutoSize = true;
            this.lblmsituacao.Location = new System.Drawing.Point(193, 271);
            this.lblmsituacao.Name = "lblmsituacao";
            this.lblmsituacao.Size = new System.Drawing.Size(0, 24);
            this.lblmsituacao.TabIndex = 10;
            // 
            // btnsair
            // 
            this.btnsair.BackColor = System.Drawing.Color.Transparent;
            this.btnsair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsair.Location = new System.Drawing.Point(339, 345);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(104, 31);
            this.btnsair.TabIndex = 11;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = false;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // frmprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 483);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.lblmsituacao);
            this.Controls.Add(this.lblmidade);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.lblsituacao);
            this.Controls.Add(this.lblidade);
            this.Controls.Add(this.txtanoatual);
            this.Controls.Add(this.lblanoatual);
            this.Controls.Add(this.txtnascimento);
            this.Controls.Add(this.lblnascimento);
            this.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Name = "frmprincipal";
            this.Text = "Calculo Idade ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnascimento;
        private System.Windows.Forms.TextBox txtnascimento;
        private System.Windows.Forms.Label lblanoatual;
        private System.Windows.Forms.TextBox txtanoatual;
        private System.Windows.Forms.Label lblidade;
        private System.Windows.Forms.Label lblsituacao;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label lblmidade;
        private System.Windows.Forms.Label lblmsituacao;
        private System.Windows.Forms.Button btnsair;
    }
}


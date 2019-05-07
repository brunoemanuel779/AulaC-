namespace Aula3
{
    partial class frmPRINCIPAL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPRINCIPAL));
            this.lblNOME = new System.Windows.Forms.Label();
            this.txtNOME = new System.Windows.Forms.TextBox();
            this.lblENDERECO = new System.Windows.Forms.Label();
            this.txtENDERECO = new System.Windows.Forms.TextBox();
            this.btnMENSSAGEM = new System.Windows.Forms.Button();
            this.txtNOME1 = new System.Windows.Forms.TextBox();
            this.txtENDERECO1 = new System.Windows.Forms.TextBox();
            this.btnSAIR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNOME
            // 
            this.lblNOME.AutoSize = true;
            this.lblNOME.BackColor = System.Drawing.Color.Transparent;
            this.lblNOME.Location = new System.Drawing.Point(58, 65);
            this.lblNOME.Name = "lblNOME";
            this.lblNOME.Size = new System.Drawing.Size(94, 32);
            this.lblNOME.TabIndex = 0;
            this.lblNOME.Text = "Nome:";
            // 
            // txtNOME
            // 
            this.txtNOME.Location = new System.Drawing.Point(64, 100);
            this.txtNOME.Name = "txtNOME";
            this.txtNOME.Size = new System.Drawing.Size(435, 39);
            this.txtNOME.TabIndex = 1;
            // 
            // lblENDERECO
            // 
            this.lblENDERECO.AutoSize = true;
            this.lblENDERECO.BackColor = System.Drawing.Color.Transparent;
            this.lblENDERECO.Location = new System.Drawing.Point(58, 142);
            this.lblENDERECO.Name = "lblENDERECO";
            this.lblENDERECO.Size = new System.Drawing.Size(131, 32);
            this.lblENDERECO.TabIndex = 2;
            this.lblENDERECO.Text = "Endereço";
            // 
            // txtENDERECO
            // 
            this.txtENDERECO.Location = new System.Drawing.Point(64, 177);
            this.txtENDERECO.Name = "txtENDERECO";
            this.txtENDERECO.Size = new System.Drawing.Size(435, 39);
            this.txtENDERECO.TabIndex = 3;
            // 
            // btnMENSSAGEM
            // 
            this.btnMENSSAGEM.Location = new System.Drawing.Point(64, 238);
            this.btnMENSSAGEM.Name = "btnMENSSAGEM";
            this.btnMENSSAGEM.Size = new System.Drawing.Size(191, 42);
            this.btnMENSSAGEM.TabIndex = 4;
            this.btnMENSSAGEM.Text = "Menssagem";
            this.btnMENSSAGEM.UseVisualStyleBackColor = true;
            this.btnMENSSAGEM.Click += new System.EventHandler(this.btnMENSSAGEM_Click);
            // 
            // txtNOME1
            // 
            this.txtNOME1.Location = new System.Drawing.Point(64, 308);
            this.txtNOME1.Name = "txtNOME1";
            this.txtNOME1.Size = new System.Drawing.Size(435, 39);
            this.txtNOME1.TabIndex = 5;
            // 
            // txtENDERECO1
            // 
            this.txtENDERECO1.Location = new System.Drawing.Point(64, 368);
            this.txtENDERECO1.Name = "txtENDERECO1";
            this.txtENDERECO1.Size = new System.Drawing.Size(435, 39);
            this.txtENDERECO1.TabIndex = 6;
            // 
            // btnSAIR
            // 
            this.btnSAIR.Location = new System.Drawing.Point(309, 238);
            this.btnSAIR.Name = "btnSAIR";
            this.btnSAIR.Size = new System.Drawing.Size(190, 42);
            this.btnSAIR.TabIndex = 7;
            this.btnSAIR.Text = "Sair";
            this.btnSAIR.UseVisualStyleBackColor = true;
            this.btnSAIR.Click += new System.EventHandler(this.btnSAIR_Click);
            // 
            // frmPRINCIPAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(585, 475);
            this.Controls.Add(this.btnSAIR);
            this.Controls.Add(this.txtENDERECO1);
            this.Controls.Add(this.txtNOME1);
            this.Controls.Add(this.btnMENSSAGEM);
            this.Controls.Add(this.txtENDERECO);
            this.Controls.Add(this.lblENDERECO);
            this.Controls.Add(this.txtNOME);
            this.Controls.Add(this.lblNOME);
            this.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "frmPRINCIPAL";
            this.Text = "Aula 3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNOME;
        private System.Windows.Forms.TextBox txtNOME;
        private System.Windows.Forms.Label lblENDERECO;
        private System.Windows.Forms.TextBox txtENDERECO;
        private System.Windows.Forms.Button btnMENSSAGEM;
        private System.Windows.Forms.TextBox txtNOME1;
        private System.Windows.Forms.TextBox txtENDERECO1;
        private System.Windows.Forms.Button btnSAIR;
    }
}


namespace Projeto_CROUD
{
    partial class Form2
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
            this.TBCPF = new System.Windows.Forms.TextBox();
            this.TBRG = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTVoltar = new System.Windows.Forms.Button();
            this.BTLimpar = new System.Windows.Forms.Button();
            this.BTAvancar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TBCPF
            // 
            this.TBCPF.Location = new System.Drawing.Point(172, 50);
            this.TBCPF.Name = "TBCPF";
            this.TBCPF.Size = new System.Drawing.Size(149, 20);
            this.TBCPF.TabIndex = 0;
            // 
            // TBRG
            // 
            this.TBRG.Location = new System.Drawing.Point(172, 87);
            this.TBRG.Name = "TBRG";
            this.TBRG.Size = new System.Drawing.Size(149, 20);
            this.TBRG.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "CPF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "RG";
            // 
            // BTVoltar
            // 
            this.BTVoltar.Location = new System.Drawing.Point(60, 137);
            this.BTVoltar.Name = "BTVoltar";
            this.BTVoltar.Size = new System.Drawing.Size(75, 23);
            this.BTVoltar.TabIndex = 4;
            this.BTVoltar.Text = "VOLTAR";
            this.BTVoltar.UseVisualStyleBackColor = true;
            // 
            // BTLimpar
            // 
            this.BTLimpar.Location = new System.Drawing.Point(184, 137);
            this.BTLimpar.Name = "BTLimpar";
            this.BTLimpar.Size = new System.Drawing.Size(75, 23);
            this.BTLimpar.TabIndex = 5;
            this.BTLimpar.Text = "LIMPAR";
            this.BTLimpar.UseVisualStyleBackColor = true;
            // 
            // BTAvancar
            // 
            this.BTAvancar.Location = new System.Drawing.Point(313, 137);
            this.BTAvancar.Name = "BTAvancar";
            this.BTAvancar.Size = new System.Drawing.Size(75, 23);
            this.BTAvancar.TabIndex = 6;
            this.BTAvancar.Text = "AVANÇAR";
            this.BTAvancar.UseVisualStyleBackColor = true;
            this.BTAvancar.Click += new System.EventHandler(this.BTAvancar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTAvancar);
            this.Controls.Add(this.BTLimpar);
            this.Controls.Add(this.BTVoltar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBRG);
            this.Controls.Add(this.TBCPF);
            this.Name = "Form2";
            this.Text = "DOCUMENTAÇÃO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBCPF;
        private System.Windows.Forms.TextBox TBRG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTVoltar;
        private System.Windows.Forms.Button BTLimpar;
        private System.Windows.Forms.Button BTAvancar;
    }
}
namespace Projeto_CROUD
{
    partial class FormIntroducao
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
            this.label2 = new System.Windows.Forms.Label();
            this.BTCadastrar = new System.Windows.Forms.Button();
            this.BTConsultar = new System.Windows.Forms.Button();
            this.BTAtualizar = new System.Windows.Forms.Button();
            this.BTDeletar = new System.Windows.Forms.Button();
            this.BTVoltar = new System.Windows.Forms.Button();
            this.BTConsultaGeral = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(208, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sistema de Cadastro";
            // 
            // BTCadastrar
            // 
            this.BTCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTCadastrar.Location = new System.Drawing.Point(233, 122);
            this.BTCadastrar.Name = "BTCadastrar";
            this.BTCadastrar.Size = new System.Drawing.Size(114, 46);
            this.BTCadastrar.TabIndex = 4;
            this.BTCadastrar.Text = "Cadastrar";
            this.BTCadastrar.UseVisualStyleBackColor = true;
            this.BTCadastrar.Click += new System.EventHandler(this.BTCadastrar_Click);
            // 
            // BTConsultar
            // 
            this.BTConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTConsultar.Location = new System.Drawing.Point(405, 122);
            this.BTConsultar.Name = "BTConsultar";
            this.BTConsultar.Size = new System.Drawing.Size(114, 46);
            this.BTConsultar.TabIndex = 5;
            this.BTConsultar.Text = "Consultar";
            this.BTConsultar.UseVisualStyleBackColor = true;
            // 
            // BTAtualizar
            // 
            this.BTAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTAtualizar.Location = new System.Drawing.Point(233, 190);
            this.BTAtualizar.Name = "BTAtualizar";
            this.BTAtualizar.Size = new System.Drawing.Size(114, 46);
            this.BTAtualizar.TabIndex = 6;
            this.BTAtualizar.Text = "Atualizar";
            this.BTAtualizar.UseVisualStyleBackColor = true;
            // 
            // BTDeletar
            // 
            this.BTDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTDeletar.Location = new System.Drawing.Point(405, 190);
            this.BTDeletar.Name = "BTDeletar";
            this.BTDeletar.Size = new System.Drawing.Size(114, 46);
            this.BTDeletar.TabIndex = 7;
            this.BTDeletar.Text = "Deletar";
            this.BTDeletar.UseVisualStyleBackColor = true;
            // 
            // BTVoltar
            // 
            this.BTVoltar.Location = new System.Drawing.Point(50, 308);
            this.BTVoltar.Name = "BTVoltar";
            this.BTVoltar.Size = new System.Drawing.Size(75, 23);
            this.BTVoltar.TabIndex = 8;
            this.BTVoltar.Text = "VOLTAR";
            this.BTVoltar.UseVisualStyleBackColor = true;
            // 
            // BTConsultaGeral
            // 
            this.BTConsultaGeral.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTConsultaGeral.Location = new System.Drawing.Point(314, 242);
            this.BTConsultaGeral.Name = "BTConsultaGeral";
            this.BTConsultaGeral.Size = new System.Drawing.Size(124, 63);
            this.BTConsultaGeral.TabIndex = 9;
            this.BTConsultaGeral.Text = "Consulta Geral";
            this.BTConsultaGeral.UseVisualStyleBackColor = true;
            // 
            // FormIntroducao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTConsultaGeral);
            this.Controls.Add(this.BTVoltar);
            this.Controls.Add(this.BTDeletar);
            this.Controls.Add(this.BTAtualizar);
            this.Controls.Add(this.BTConsultar);
            this.Controls.Add(this.BTCadastrar);
            this.Controls.Add(this.label2);
            this.Name = "FormIntroducao";
            this.Text = "Sistema de cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTCadastrar;
        private System.Windows.Forms.Button BTConsultar;
        private System.Windows.Forms.Button BTAtualizar;
        private System.Windows.Forms.Button BTDeletar;
        private System.Windows.Forms.Button BTVoltar;
        private System.Windows.Forms.Button BTConsultaGeral;
    }
}
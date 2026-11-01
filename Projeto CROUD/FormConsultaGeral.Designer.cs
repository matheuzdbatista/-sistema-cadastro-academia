namespace Projeto_CROUD
{
    partial class FormConsultaGeral
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
            this.DGVAlunos = new System.Windows.Forms.DataGridView();
            this.BTVoltar = new System.Windows.Forms.Button();
            this.BTAtualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVAlunos
            // 
            this.DGVAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVAlunos.Location = new System.Drawing.Point(0, 0);
            this.DGVAlunos.Name = "DGVAlunos";
            this.DGVAlunos.Size = new System.Drawing.Size(801, 348);
            this.DGVAlunos.TabIndex = 0;
            // 
            // BTVoltar
            // 
            this.BTVoltar.Location = new System.Drawing.Point(0, 325);
            this.BTVoltar.Name = "BTVoltar";
            this.BTVoltar.Size = new System.Drawing.Size(75, 23);
            this.BTVoltar.TabIndex = 1;
            this.BTVoltar.Text = "VOLTAR";
            this.BTVoltar.UseVisualStyleBackColor = true;
            // 
            // BTAtualizar
            // 
            this.BTAtualizar.Location = new System.Drawing.Point(726, 325);
            this.BTAtualizar.Name = "BTAtualizar";
            this.BTAtualizar.Size = new System.Drawing.Size(75, 23);
            this.BTAtualizar.TabIndex = 2;
            this.BTAtualizar.Text = "ATUALIZAR";
            this.BTAtualizar.UseVisualStyleBackColor = true;
            // 
            // FormConsultaGeral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTAtualizar);
            this.Controls.Add(this.BTVoltar);
            this.Controls.Add(this.DGVAlunos);
            this.Name = "FormConsultaGeral";
            this.Text = "FormConsultaGeral";
            ((System.ComponentModel.ISupportInitialize)(this.DGVAlunos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVAlunos;
        private System.Windows.Forms.Button BTVoltar;
        private System.Windows.Forms.Button BTAtualizar;
    }
}
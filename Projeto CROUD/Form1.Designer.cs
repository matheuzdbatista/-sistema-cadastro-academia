namespace Projeto_CROUD
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TBNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBEndereco = new System.Windows.Forms.TextBox();
            this.TBCep = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CBEstado = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TBCidade = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MCalendario = new System.Windows.Forms.MonthCalendar();
            this.RMasculino = new System.Windows.Forms.RadioButton();
            this.RFeminino = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTLimpar = new System.Windows.Forms.Button();
            this.BTAvancar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TBTelefone = new System.Windows.Forms.TextBox();
            this.BTVoltar = new System.Windows.Forms.Button();
            this.LIDAluno = new System.Windows.Forms.Label();
            this.TBIDAluno = new System.Windows.Forms.TextBox();
            this.BTOK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // TBNome
            // 
            this.TBNome.Location = new System.Drawing.Point(107, 29);
            this.TBNome.Name = "TBNome";
            this.TBNome.Size = new System.Drawing.Size(143, 20);
            this.TBNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Endereço:";
            // 
            // TBEndereco
            // 
            this.TBEndereco.Location = new System.Drawing.Point(106, 55);
            this.TBEndereco.Name = "TBEndereco";
            this.TBEndereco.Size = new System.Drawing.Size(143, 20);
            this.TBEndereco.TabIndex = 3;
            // 
            // TBCep
            // 
            this.TBCep.Location = new System.Drawing.Point(106, 81);
            this.TBCep.Name = "TBCep";
            this.TBCep.Size = new System.Drawing.Size(143, 20);
            this.TBCep.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "CEP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Estado:";
            // 
            // CBEstado
            // 
            this.CBEstado.FormattingEnabled = true;
            this.CBEstado.Items.AddRange(new object[] {
            "Acre",
            "Alagoas",
            "Amapá",
            "Amazonas",
            "Bahia",
            "Ceará",
            "Distrito Federal",
            "Espírito Santo",
            "Goiás",
            "Maranhão",
            "Mato Grosso",
            "Mato Grosso do Sul",
            "Minas Gerais",
            "Pará",
            "Paraíba",
            "Paraná",
            "Pernambuco",
            "Piauí",
            "Rio de Janeiro",
            "Rio Grande do Norte",
            "Rio Grande do Sul",
            "Rondônia",
            "Roraima",
            "Santa Catarina",
            "São Paulo",
            "Sergipe",
            "Tocantins"});
            this.CBEstado.Location = new System.Drawing.Point(107, 162);
            this.CBEstado.Name = "CBEstado";
            this.CBEstado.Size = new System.Drawing.Size(142, 21);
            this.CBEstado.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cidade:";
            // 
            // TBCidade
            // 
            this.TBCidade.Location = new System.Drawing.Point(106, 107);
            this.TBCidade.Name = "TBCidade";
            this.TBCidade.Size = new System.Drawing.Size(144, 20);
            this.TBCidade.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(286, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Data de Nascimento";
            // 
            // MCalendario
            // 
            this.MCalendario.Location = new System.Drawing.Point(289, 58);
            this.MCalendario.Name = "MCalendario";
            this.MCalendario.TabIndex = 11;
            // 
            // RMasculino
            // 
            this.RMasculino.AutoSize = true;
            this.RMasculino.Location = new System.Drawing.Point(6, 26);
            this.RMasculino.Name = "RMasculino";
            this.RMasculino.Size = new System.Drawing.Size(73, 17);
            this.RMasculino.TabIndex = 13;
            this.RMasculino.TabStop = true;
            this.RMasculino.Text = "Masculino";
            this.RMasculino.UseVisualStyleBackColor = true;
            // 
            // RFeminino
            // 
            this.RFeminino.AutoSize = true;
            this.RFeminino.Location = new System.Drawing.Point(6, 63);
            this.RFeminino.Name = "RFeminino";
            this.RFeminino.Size = new System.Drawing.Size(67, 17);
            this.RFeminino.TabIndex = 14;
            this.RFeminino.TabStop = true;
            this.RFeminino.Text = "Feminino";
            this.RFeminino.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RFeminino);
            this.groupBox1.Controls.Add(this.RMasculino);
            this.groupBox1.Location = new System.Drawing.Point(47, 194);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // BTLimpar
            // 
            this.BTLimpar.Location = new System.Drawing.Point(346, 300);
            this.BTLimpar.Name = "BTLimpar";
            this.BTLimpar.Size = new System.Drawing.Size(75, 23);
            this.BTLimpar.TabIndex = 16;
            this.BTLimpar.Text = "LIMPAR";
            this.BTLimpar.UseVisualStyleBackColor = true;
            // 
            // BTAvancar
            // 
            this.BTAvancar.Location = new System.Drawing.Point(441, 300);
            this.BTAvancar.Name = "BTAvancar";
            this.BTAvancar.Size = new System.Drawing.Size(75, 23);
            this.BTAvancar.TabIndex = 17;
            this.BTAvancar.Text = "AVANÇAR";
            this.BTAvancar.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Telefone";
            // 
            // TBTelefone
            // 
            this.TBTelefone.Location = new System.Drawing.Point(107, 136);
            this.TBTelefone.Name = "TBTelefone";
            this.TBTelefone.Size = new System.Drawing.Size(143, 20);
            this.TBTelefone.TabIndex = 19;
            // 
            // BTVoltar
            // 
            this.BTVoltar.Location = new System.Drawing.Point(47, 300);
            this.BTVoltar.Name = "BTVoltar";
            this.BTVoltar.Size = new System.Drawing.Size(75, 23);
            this.BTVoltar.TabIndex = 20;
            this.BTVoltar.Text = "VOLTAR";
            this.BTVoltar.UseVisualStyleBackColor = true;
            // 
            // LIDAluno
            // 
            this.LIDAluno.AutoSize = true;
            this.LIDAluno.Location = new System.Drawing.Point(286, 247);
            this.LIDAluno.Name = "LIDAluno";
            this.LIDAluno.Size = new System.Drawing.Size(66, 13);
            this.LIDAluno.TabIndex = 21;
            this.LIDAluno.Text = "ID do Aluno:";
            // 
            // TBIDAluno
            // 
            this.TBIDAluno.Location = new System.Drawing.Point(358, 244);
            this.TBIDAluno.Name = "TBIDAluno";
            this.TBIDAluno.Size = new System.Drawing.Size(143, 20);
            this.TBIDAluno.TabIndex = 22;
            // 
            // BTOK
            // 
            this.BTOK.Location = new System.Drawing.Point(507, 244);
            this.BTOK.Name = "BTOK";
            this.BTOK.Size = new System.Drawing.Size(35, 23);
            this.BTOK.TabIndex = 23;
            this.BTOK.Text = "OK";
            this.BTOK.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 342);
            this.Controls.Add(this.BTOK);
            this.Controls.Add(this.TBIDAluno);
            this.Controls.Add(this.LIDAluno);
            this.Controls.Add(this.BTVoltar);
            this.Controls.Add(this.TBTelefone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BTAvancar);
            this.Controls.Add(this.BTLimpar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MCalendario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TBCidade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CBEstado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBCep);
            this.Controls.Add(this.TBEndereco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBNome);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Dados Pessoais";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBEndereco;
        private System.Windows.Forms.TextBox TBCep;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CBEstado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBCidade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MonthCalendar MCalendario;
        private System.Windows.Forms.RadioButton RMasculino;
        private System.Windows.Forms.RadioButton RFeminino;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTLimpar;
        private System.Windows.Forms.Button BTAvancar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TBTelefone;
        private System.Windows.Forms.Button BTVoltar;
        private System.Windows.Forms.Label LIDAluno;
        private System.Windows.Forms.TextBox TBIDAluno;
        private System.Windows.Forms.Button BTOK;
    }
}


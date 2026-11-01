using System;
using System.Windows.Forms;

namespace Projeto_CROUD
{
    public partial class FormIntroducao : Form
    {
        public FormIntroducao()
        {
            InitializeComponent();

            BTCadastrar.Click -= BTCadastrar_Click;
            BTConsultar.Click -= BTConsultar_Click;
            BTAtualizar.Click -= BTAtualizar_Click;
            BTDeletar.Click -= BTDeletar_Click;
            BTVoltar.Click -= BTVoltar_Click;
            BTConsultaGeral.Click -= BTConsultaGeral_Click;

            BTCadastrar.Click += BTCadastrar_Click;
            BTConsultar.Click += BTConsultar_Click;
            BTAtualizar.Click += BTAtualizar_Click;
            BTDeletar.Click += BTDeletar_Click;
            BTVoltar.Click += BTVoltar_Click;
            BTConsultaGeral.Click += BTConsultaGeral_Click;
        }

        private void BTCadastrar_Click(object sender, EventArgs e)
        {
            DadosSistema.Modo = "Cadastrar";

            DadosSistema.Nome = "";
            DadosSistema.Telefone = "";
            DadosSistema.Endereco = "";
            DadosSistema.CEP = "";
            DadosSistema.Cidade = "";
            DadosSistema.Estado = "";
            DadosSistema.Sexo = "";
            DadosSistema.DataNascimento = "";
            DadosSistema.CPF = "";
            DadosSistema.RG = "";
            DadosSistema.IdSelecionado = -1;

            Form1 tela = new Form1();

            tela.Show();

            this.Hide();
        }

        private void BTConsultar_Click(object sender, EventArgs e)
        {
            DadosSistema.Modo = "Consultar";

            Form1 tela = new Form1();

            tela.Show();

            this.Hide();
        }

        private void BTAtualizar_Click(object sender, EventArgs e)
        {
            DadosSistema.Modo = "Atualizar";

            Form1 tela = new Form1();

            tela.Show();

            this.Hide();
        }

        private void BTDeletar_Click(object sender, EventArgs e)
        {
            DadosSistema.Modo = "Deletar";

            Form1 tela = new Form1();

            tela.Show();

            this.Hide();
        }

        private void BTConsultaGeral_Click(object sender, EventArgs e)
        {
            FormConsultaGeral tela =
                new FormConsultaGeral();

            tela.Show();

            this.Hide();
        }

        private void BTVoltar_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show(
                "Deseja realmente voltar para a tela inicial?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resposta == DialogResult.Yes)
            {
                FormInicial tela =
                    new FormInicial();

                tela.Show();

                this.Close();
            }
        }
    }
}
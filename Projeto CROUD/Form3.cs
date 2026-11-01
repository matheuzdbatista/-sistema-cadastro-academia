using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Projeto_CROUD
{
    public partial class Form3 : Form
    {
        private Form2 tela2;
        private bool cadastroSalvo = false;

        public Form3(Form2 telaOrigem)
        {
            InitializeComponent();

            tela2 = telaOrigem;

            BTVoltar.Click -= BTVoltar_Click;
            BTSalvar.Click -= BTSalvar_Click;
            BTEditar.Click -= BTEditar_Click;
            BTExcluir.Click -= BTExcluir_Click;

            BTVoltar.Click += BTVoltar_Click;
            BTSalvar.Click += BTSalvar_Click;
            BTEditar.Click += BTEditar_Click;
            BTExcluir.Click += BTExcluir_Click;

            ConfigurarModalidades();
            ConfigurarTela();
        }

        private void ConfigurarModalidades()
        {
            RBMusculacao.AutoCheck = false;
            RBCross.AutoCheck = false;
            RBPilates.AutoCheck = false;
            RBDanca.AutoCheck = false;
            RBArtesMarciais.AutoCheck = false;

            RBMusculacao.Click -= Modalidade_Click;
            RBCross.Click -= Modalidade_Click;
            RBPilates.Click -= Modalidade_Click;
            RBDanca.Click -= Modalidade_Click;
            RBArtesMarciais.Click -= Modalidade_Click;

            RBMusculacao.Click += Modalidade_Click;
            RBCross.Click += Modalidade_Click;
            RBPilates.Click += Modalidade_Click;
            RBDanca.Click += Modalidade_Click;
            RBArtesMarciais.Click += Modalidade_Click;
        }

        private void ConfigurarTela()
        {
            TBIDCliente.Visible = true;
            TBIDCliente.Enabled = false;

            BTSalvar.Visible = false;
            BTEditar.Visible = false;
            BTExcluir.Visible = false;

            if (DadosSistema.Modo == "Cadastrar")
            {
                TBIDCliente.Text = Conexao.GerarProximoId().ToString();
                BTSalvar.Visible = true;
                BTSalvar.Enabled = true;
            }
            else if (DadosSistema.Modo == "Consultar")
            {
                TBIDCliente.Text = DadosSistema.IdSelecionado.ToString();
                CarregarDadosInteresse();
                DesabilitarCampos();
            }
            else if (DadosSistema.Modo == "Atualizar")
            {
                TBIDCliente.Text = DadosSistema.IdSelecionado.ToString();
                CarregarDadosInteresse();
                BTEditar.Visible = true;
            }
            else if (DadosSistema.Modo == "Deletar")
            {
                TBIDCliente.Text = DadosSistema.IdSelecionado.ToString();
                CarregarDadosInteresse();
                DesabilitarCampos();
                BTExcluir.Visible = true;
            }
        }

        private void DesabilitarCampos()
        {
            RBEmagrecimento.Enabled = false;
            RBSaude.Enabled = false;
            RBCondicionamentoFisico.Enabled = false;
            RBHipertrofia.Enabled = false;

            RBMusculacao.Enabled = false;
            RBCross.Enabled = false;
            RBPilates.Enabled = false;
            RBDanca.Enabled = false;
            RBArtesMarciais.Enabled = false;

            RBManha.Enabled = false;
            RBTarde.Enabled = false;
            RBNoite.Enabled = false;
        }

        private void Modalidade_Click(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            rb.Checked = !rb.Checked;
        }

        private string PegarObjetivo()
        {
            if (RBEmagrecimento.Checked) return "Emagrecimento";
            if (RBSaude.Checked) return "Saúde / Qualidade de Vida";
            if (RBCondicionamentoFisico.Checked) return "Condicionamento Físico";
            if (RBHipertrofia.Checked) return "Hipertrofia";

            return "";
        }

        private string PegarModalidades()
        {
            string modalidades = "";

            if (RBMusculacao.Checked) modalidades += "Musculação; ";
            if (RBCross.Checked) modalidades += "Cross Training / Funcional; ";
            if (RBPilates.Checked) modalidades += "Pilates / Yoga; ";
            if (RBDanca.Checked) modalidades += "Dança; ";
            if (RBArtesMarciais.Checked) modalidades += "Artes Marciais; ";

            return modalidades;
        }

        private string PegarHorario()
        {
            if (RBManha.Checked) return "Manhã";
            if (RBTarde.Checked) return "Tarde";
            if (RBNoite.Checked) return "Noite";

            return "";
        }

        private void CarregarDadosInteresse()
        {
            SqlConnection conexao = Conexao.Conectar();

            string sql =
                "SELECT Objetivo, Modalidades, Horario FROM Cadastro WHERE Id = @Id";

            SqlCommand comando = new SqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@Id", DadosSistema.IdSelecionado);

            SqlDataReader reader = comando.ExecuteReader();

            if (reader.Read())
            {
                string objetivo = reader["Objetivo"].ToString();
                string modalidades = reader["Modalidades"].ToString();
                string horario = reader["Horario"].ToString();

                RBEmagrecimento.Checked = objetivo == "Emagrecimento";
                RBSaude.Checked = objetivo == "Saúde / Qualidade de Vida";
                RBCondicionamentoFisico.Checked = objetivo == "Condicionamento Físico";
                RBHipertrofia.Checked = objetivo == "Hipertrofia";

                RBMusculacao.Checked = modalidades.Contains("Musculação");
                RBCross.Checked = modalidades.Contains("Cross");
                RBPilates.Checked = modalidades.Contains("Pilates");
                RBDanca.Checked = modalidades.Contains("Dança");
                RBArtesMarciais.Checked = modalidades.Contains("Artes Marciais");

                RBManha.Checked = horario == "Manhã";
                RBTarde.Checked = horario == "Tarde";
                RBNoite.Checked = horario == "Noite";
            }

            conexao.Close();
        }

        private void BTVoltar_Click(object sender, EventArgs e)
        {
            if (tela2 != null)
            {
                tela2.Show();
            }
            else
            {
                Form1 tela1 = new Form1();
                tela1.Show();
            }

            this.Close();
        }

        private void BTSalvar_Click(object sender, EventArgs e)
        {
            if (cadastroSalvo)
                return;

            cadastroSalvo = true;
            BTSalvar.Enabled = false;

            if ((RBEmagrecimento.Checked == false &&
                 RBSaude.Checked == false &&
                 RBCondicionamentoFisico.Checked == false &&
                 RBHipertrofia.Checked == false) ||

                (RBMusculacao.Checked == false &&
                 RBCross.Checked == false &&
                 RBPilates.Checked == false &&
                 RBDanca.Checked == false &&
                 RBArtesMarciais.Checked == false) ||

                (RBManha.Checked == false &&
                 RBTarde.Checked == false &&
                 RBNoite.Checked == false))
            {
                MessageBox.Show("Selecione todas as opções antes de salvar.");
                cadastroSalvo = false;
                BTSalvar.Enabled = true;
                return;
            }

            int id = Conexao.GerarProximoId();

            SqlConnection conexao = Conexao.Conectar();

            string sql =
            @"INSERT INTO Cadastro
            (Id, Nome, Telefone, Endereco, CEP, Cidade, Estado, Sexo, DataNascimento, CPF, RG, Objetivo, Modalidades, Horario)
            VALUES
            (@Id, @Nome, @Telefone, @Endereco, @CEP, @Cidade, @Estado, @Sexo, @DataNascimento, @CPF, @RG, @Objetivo, @Modalidades, @Horario)";

            SqlCommand comando = new SqlCommand(sql, conexao);

            comando.Parameters.AddWithValue("@Id", id);
            comando.Parameters.AddWithValue("@Nome", DadosSistema.Nome);
            comando.Parameters.AddWithValue("@Telefone", DadosSistema.Telefone);
            comando.Parameters.AddWithValue("@Endereco", DadosSistema.Endereco);
            comando.Parameters.AddWithValue("@CEP", DadosSistema.CEP);
            comando.Parameters.AddWithValue("@Cidade", DadosSistema.Cidade);
            comando.Parameters.AddWithValue("@Estado", DadosSistema.Estado);
            comando.Parameters.AddWithValue("@Sexo", DadosSistema.Sexo);
            comando.Parameters.AddWithValue("@DataNascimento", DadosSistema.DataNascimento);
            comando.Parameters.AddWithValue("@CPF", DadosSistema.CPF);
            comando.Parameters.AddWithValue("@RG", DadosSistema.RG);
            comando.Parameters.AddWithValue("@Objetivo", PegarObjetivo());
            comando.Parameters.AddWithValue("@Modalidades", PegarModalidades());
            comando.Parameters.AddWithValue("@Horario", PegarHorario());

            comando.ExecuteNonQuery();
            conexao.Close();

            DadosSistema.IdSelecionado = id;

            MessageBox.Show(
                "Cadastro realizado com sucesso!" +
                "\nNome: " + DadosSistema.Nome +
                "\nID: " + id +
                "\nTelefone: " + DadosSistema.Telefone
            );

            ArquivoLog.Registrar("Cadastro realizado - ID: " + id);

            FormIntroducao tela = new FormIntroducao();
            tela.Show();

            this.Close();
        }

        private void BTEditar_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show(
                "Deseja salvar as alterações?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resposta == DialogResult.No)
            {
                return;
            }

            SqlConnection conexao = Conexao.Conectar();

            string sql =
            @"UPDATE Cadastro SET
                Objetivo = @Objetivo,
                Modalidades = @Modalidades,
                Horario = @Horario
              WHERE Id = @Id";

            SqlCommand comando = new SqlCommand(sql, conexao);

            comando.Parameters.AddWithValue("@Objetivo", PegarObjetivo());
            comando.Parameters.AddWithValue("@Modalidades", PegarModalidades());
            comando.Parameters.AddWithValue("@Horario", PegarHorario());
            comando.Parameters.AddWithValue("@Id", DadosSistema.IdSelecionado);

            comando.ExecuteNonQuery();
            conexao.Close();

            MessageBox.Show("Dados atualizados com sucesso!");

            ArquivoLog.Registrar(
                "Cadastro atualizado - ID: " + DadosSistema.IdSelecionado
            );

            FormIntroducao tela = new FormIntroducao();
            tela.Show();

            this.Close();
        }

        private void BTExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show(
                "Deseja realmente excluir este cadastro?",
                "Confirmar exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resposta == DialogResult.No)
                return;

            SqlConnection conexao = Conexao.Conectar();

            string sql = "DELETE FROM Cadastro WHERE Id = @Id";

            SqlCommand comando = new SqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@Id", DadosSistema.IdSelecionado);

            comando.ExecuteNonQuery();
            conexao.Close();

            MessageBox.Show("Cadastro excluído com sucesso!");

            ArquivoLog.Registrar(
                "Cadastro excluído - ID: " + DadosSistema.IdSelecionado
            );

            FormIntroducao tela = new FormIntroducao();
            tela.Show();

            this.Close();
        }
    }
}
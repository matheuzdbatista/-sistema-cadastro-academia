using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Projeto_CROUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            BTLimpar.Click += BTLimpar_Click;
            BTAvancar.Click += BTAvancar_Click;
            BTVoltar.Click += BTVoltar_Click;
            BTOK.Click += BTOK_Click;

            TBNome.KeyPress += ApenasLetras_KeyPress;
            TBCidade.KeyPress += ApenasLetras_KeyPress;
            TBIDAluno.KeyPress += ApenasNumeros_KeyPress;

            TBCep.TextChanged += TBCep_TextChanged;
            TBTelefone.TextChanged += TBTelefone_TextChanged;

            CarregarEstados();

            ConfigurarTelaPorModo();
        }

        private void CarregarEstados()
        {
            CBEstado.Items.Clear();

            CBEstado.Items.Add("Acre");
            CBEstado.Items.Add("Alagoas");
            CBEstado.Items.Add("Amapá");
            CBEstado.Items.Add("Amazonas");
            CBEstado.Items.Add("Bahia");
            CBEstado.Items.Add("Ceará");
            CBEstado.Items.Add("Distrito Federal");
            CBEstado.Items.Add("Espírito Santo");
            CBEstado.Items.Add("Goiás");
            CBEstado.Items.Add("Maranhão");
            CBEstado.Items.Add("Mato Grosso");
            CBEstado.Items.Add("Mato Grosso do Sul");
            CBEstado.Items.Add("Minas Gerais");
            CBEstado.Items.Add("Pará");
            CBEstado.Items.Add("Paraíba");
            CBEstado.Items.Add("Paraná");
            CBEstado.Items.Add("Pernambuco");
            CBEstado.Items.Add("Piauí");
            CBEstado.Items.Add("Rio de Janeiro");
            CBEstado.Items.Add("Rio Grande do Norte");
            CBEstado.Items.Add("Rio Grande do Sul");
            CBEstado.Items.Add("Rondônia");
            CBEstado.Items.Add("Roraima");
            CBEstado.Items.Add("Santa Catarina");
            CBEstado.Items.Add("São Paulo");
            CBEstado.Items.Add("Sergipe");
            CBEstado.Items.Add("Tocantins");

            CBEstado.DropDownStyle =
                ComboBoxStyle.DropDownList;
        }

        private void ConfigurarTelaPorModo()
        {
            if (DadosSistema.Modo == "Cadastrar")
            {
                LIDAluno.Visible = false;
                TBIDAluno.Visible = false;
                BTOK.Visible = false;

                TBNome.Enabled = true;
                MCalendario.Enabled = true;

                RMasculino.Enabled = true;
                RFeminino.Enabled = true;

                TBEndereco.Enabled = true;
                TBCep.Enabled = true;
                TBTelefone.Enabled = true;
                TBCidade.Enabled = true;
                CBEstado.Enabled = true;

                BTLimpar.Visible = true;
                BTAvancar.Visible = true;
            }
            else
            {
                LIDAluno.Visible = true;
                TBIDAluno.Visible = true;
                BTOK.Visible = true;

                TBNome.Enabled = false;
                MCalendario.Enabled = false;

                RMasculino.Enabled = false;
                RFeminino.Enabled = false;

                TBEndereco.Enabled = false;
                TBCep.Enabled = false;
                TBTelefone.Enabled = false;
                TBCidade.Enabled = false;
                CBEstado.Enabled = false;

                BTLimpar.Visible = false;
                BTAvancar.Visible = false;

                TBIDAluno.Enabled = true;

                TBIDAluno.Focus();
            }
        }

        private void LiberarCampos()
        {
            TBEndereco.Enabled = true;
            TBCep.Enabled = true;
            TBTelefone.Enabled = true;
            TBCidade.Enabled = true;
            CBEstado.Enabled = true;

            BTAvancar.Visible = true;
        }

        private void ApenasNumeros_KeyPress(
            object sender,
            KeyPressEventArgs e
        )
        {
            if (!char.IsDigit(e.KeyChar) &&
                e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void ApenasLetras_KeyPress(
            object sender,
            KeyPressEventArgs e
        )
        {
            if (!char.IsLetter(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar) &&
                e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void TBCep_TextChanged(
            object sender,
            EventArgs e
        )
        {
            string numeros = "";

            foreach (char c in TBCep.Text)
            {
                if (char.IsDigit(c))
                    numeros += c;
            }

            if (numeros.Length > 8)
                numeros = numeros.Substring(0, 8);

            string formatado = "";

            if (numeros.Length > 0)
                formatado =
                    numeros.Substring(
                        0,
                        Math.Min(5, numeros.Length)
                    );

            if (numeros.Length > 5)
                formatado += "-" +
                    numeros.Substring(
                        5,
                        Math.Min(3,
                        numeros.Length - 5)
                    );

            TBCep.TextChanged -= TBCep_TextChanged;

            TBCep.Text = formatado;

            TBCep.SelectionStart =
                TBCep.Text.Length;

            TBCep.TextChanged += TBCep_TextChanged;
        }

        private void TBTelefone_TextChanged(
            object sender,
            EventArgs e
        )
        {
            string numeros = "";

            foreach (char c in TBTelefone.Text)
            {
                if (char.IsDigit(c))
                    numeros += c;
            }

            if (numeros.Length > 11)
                numeros = numeros.Substring(0, 11);

            string formatado = "";

            if (numeros.Length > 0)
                formatado = "(" +
                    numeros.Substring(
                        0,
                        Math.Min(2, numeros.Length)
                    );

            if (numeros.Length >= 2)
                formatado += ") ";

            if (numeros.Length > 2)
                formatado += numeros.Substring(
                    2,
                    Math.Min(
                        5,
                        numeros.Length - 2
                    )
                );

            if (numeros.Length > 7)
                formatado += "-" +
                    numeros.Substring(
                        7,
                        Math.Min(
                            4,
                            numeros.Length - 7
                        )
                    );

            TBTelefone.TextChanged -=
                TBTelefone_TextChanged;

            TBTelefone.Text = formatado;

            TBTelefone.SelectionStart =
                TBTelefone.Text.Length;

            TBTelefone.TextChanged +=
                TBTelefone_TextChanged;
        }

        private bool MaiorDe16Anos()
        {
            DateTime nascimento =
                MCalendario.SelectionStart;

            DateTime hoje =
                DateTime.Today;

            int idade =
                hoje.Year - nascimento.Year;

            if (nascimento.Date >
                hoje.AddYears(-idade))
            {
                idade--;
            }

            return idade >= 16;
        }

        private void BTLimpar_Click(
            object sender,
            EventArgs e
        )
        {
            TBNome.Clear();
            TBEndereco.Clear();
            TBCep.Clear();
            TBTelefone.Clear();
            TBCidade.Clear();

            CBEstado.SelectedIndex = -1;

            RMasculino.Checked = false;
            RFeminino.Checked = false;

            MCalendario.SetDate(
                DateTime.Today
            );

            TBNome.Focus();
        }

        private void BTVoltar_Click(
            object sender,
            EventArgs e
        )
        {
            FormIntroducao tela =
                new FormIntroducao();

            tela.Show();

            this.Close();
        }

        private void BTOK_Click(
            object sender,
            EventArgs e
        )
        {
            if (TBIDAluno.Text == "")
            {
                MessageBox.Show(
                    "ID não encontrado."
                );

                return;
            }

            int id =
                int.Parse(TBIDAluno.Text);

            SqlConnection conexao =
                Conexao.Conectar();

            string sql =
                "SELECT * FROM Cadastro WHERE Id = @Id";

            SqlCommand comando =
                new SqlCommand(
                    sql,
                    conexao
                );

            comando.Parameters.AddWithValue(
                "@Id",
                id
            );

            SqlDataReader reader =
                comando.ExecuteReader();

            if (reader.Read())
            {
                DadosSistema.IdSelecionado = id;

                DadosSistema.Nome =
                    reader["Nome"].ToString();

                DadosSistema.Telefone =
                    reader["Telefone"].ToString();

                DadosSistema.Endereco =
                    reader["Endereco"].ToString();

                DadosSistema.CEP =
                    reader["CEP"].ToString();

                DadosSistema.Cidade =
                    reader["Cidade"].ToString();

                DadosSistema.Estado =
                    reader["Estado"].ToString();

                DadosSistema.Sexo =
                    reader["Sexo"].ToString();

                DadosSistema.DataNascimento =
                    reader["DataNascimento"]
                    .ToString();

                DadosSistema.CPF =
                    reader["CPF"].ToString();

                DadosSistema.RG =
                    reader["RG"].ToString();

                TBNome.Text =
                    DadosSistema.Nome;

                TBTelefone.Text =
                    DadosSistema.Telefone;

                TBEndereco.Text =
                    DadosSistema.Endereco;

                TBCep.Text =
                    DadosSistema.CEP;

                TBCidade.Text =
                    DadosSistema.Cidade;

                CBEstado.Text =
                    DadosSistema.Estado;

                if (DadosSistema.Sexo ==
                    "Masculino")
                {
                    RMasculino.Checked = true;
                }
                else
                {
                    RFeminino.Checked = true;
                }

                if (DadosSistema
                    .DataNascimento != "")
                {
                    MCalendario.SetDate(
                        Convert.ToDateTime(
                            DadosSistema
                            .DataNascimento
                        )
                    );
                }

                if (DadosSistema.Modo ==
                    "Consultar")
                {
                    BTAvancar.Visible = true;
                }
                else
                {
                    LiberarCampos();
                }

                MessageBox.Show(
                    "Cadastro encontrado!"
                );

                ArquivoLog.Registrar(
                    "Consulta realizada - ID: " +
                    id
                );
            }
            else
            {
                MessageBox.Show(
                    "ID não encontrado."
                );
            }

            conexao.Close();
        }

        private void BTAvancar_Click(
            object sender,
            EventArgs e
        )
        {
            if (DadosSistema.Modo ==
                "Cadastrar")
            {
                if (TBNome.Text == "" ||
                    TBEndereco.Text == "" ||
                    TBCep.Text.Length != 9 ||
                    TBTelefone.Text.Length != 15 ||
                    TBCidade.Text == "" ||
                    CBEstado.SelectedIndex == -1 ||
                    (RMasculino.Checked == false &&
                     RFeminino.Checked == false))
                {
                    MessageBox.Show(
                        "Preencha todos os dados!"
                    );

                    return;
                }

                if (MaiorDe16Anos() ==
                    false)
                {
                    MessageBox.Show(
                        "Idade insuficiente para cadastro"
                    );

                    return;
                }
            }

            DadosSistema.Nome =
                TBNome.Text;

            DadosSistema.Telefone =
                TBTelefone.Text;

            DadosSistema.Endereco =
                TBEndereco.Text;

            DadosSistema.CEP =
                TBCep.Text;

            DadosSistema.Cidade =
                TBCidade.Text;

            DadosSistema.Estado =
                CBEstado.Text;

            if (RMasculino.Checked)
                DadosSistema.Sexo =
                    "Masculino";
            else if (RFeminino.Checked)
                DadosSistema.Sexo =
                    "Feminino";

            DadosSistema.DataNascimento =
                MCalendario
                .SelectionStart
                .ToShortDateString();

            Form2 tela2 =
                new Form2(this);

            tela2.Show();

            this.Hide();
        }
    }
}
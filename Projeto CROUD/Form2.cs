using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Projeto_CROUD
{
    public partial class Form2 : Form
    {
        private Form1 tela1;

        public Form2(Form1 telaOrigem)
        {
            InitializeComponent();

            tela1 = telaOrigem;

            BTVoltar.Click -= BTVoltar_Click;
            BTLimpar.Click -= BTLimpar_Click;
            BTAvancar.Click -= BTAvancar_Click;

            BTVoltar.Click += BTVoltar_Click;
            BTLimpar.Click += BTLimpar_Click;
            BTAvancar.Click += BTAvancar_Click;

            TBCPF.TextChanged -= TBCPF_TextChanged;
            TBRG.TextChanged -= TBRG_TextChanged;

            TBCPF.TextChanged += TBCPF_TextChanged;
            TBRG.TextChanged += TBRG_TextChanged;

            CarregarDados();
        }

        private void CarregarDados()
        {
            TBCPF.Visible = true;
            TBRG.Visible = true;

            TBCPF.BringToFront();
            TBRG.BringToFront();

            if (DadosSistema.Modo == "Cadastrar")
            {
                TBCPF.Clear();
                TBRG.Clear();

                DadosSistema.CPF = "";
                DadosSistema.RG = "";

                TBCPF.Enabled = true;
                TBRG.Enabled = true;

                TBCPF.ReadOnly = false;
                TBRG.ReadOnly = false;

                BTLimpar.Visible = true;

                TBCPF.Focus();
            }
            else
            {
                CarregarCpfRgDoBanco();

                TBCPF.Enabled = true;
                TBRG.Enabled = true;

                if (DadosSistema.Modo == "Consultar")
                {
                    TBCPF.ReadOnly = true;
                    TBRG.ReadOnly = true;

                    BTLimpar.Visible = false;
                }
                else
                {
                    TBCPF.ReadOnly = false;
                    TBRG.ReadOnly = false;

                    BTLimpar.Visible = true;
                }
            }
        }

        private void CarregarCpfRgDoBanco()
        {
            SqlConnection conexao = Conexao.Conectar();

            string sql = "SELECT CPF, RG FROM Cadastro WHERE Id = @Id";

            SqlCommand comando = new SqlCommand(sql, conexao);

            comando.Parameters.AddWithValue(
                "@Id",
                DadosSistema.IdSelecionado
            );

            SqlDataReader reader = comando.ExecuteReader();

            if (reader.Read())
            {
                TBCPF.Text = reader["CPF"].ToString();
                TBRG.Text = reader["RG"].ToString();

                DadosSistema.CPF = TBCPF.Text;
                DadosSistema.RG = TBRG.Text;
            }

            conexao.Close();
        }

        private void BTVoltar_Click(object sender, EventArgs e)
        {
            if (DadosSistema.Modo != "Cadastrar")
            {
                DadosSistema.CPF = TBCPF.Text;
                DadosSistema.RG = TBRG.Text;
            }

            tela1.Show();
            this.Close();
        }

        private void BTLimpar_Click(object sender, EventArgs e)
        {
            TBCPF.Clear();
            TBRG.Clear();

            TBCPF.Focus();
        }

        private void TBCPF_TextChanged(object sender, EventArgs e)
        {
            string numeros = "";

            foreach (char c in TBCPF.Text)
            {
                if (char.IsDigit(c))
                {
                    numeros += c;
                }
            }

            if (numeros.Length > 11)
            {
                numeros = numeros.Substring(0, 11);
            }

            string formatado = "";

            if (numeros.Length > 0)
            {
                formatado = numeros.Substring(0, Math.Min(3, numeros.Length));
            }

            if (numeros.Length > 3)
            {
                formatado += "." + numeros.Substring(3, Math.Min(3, numeros.Length - 3));
            }

            if (numeros.Length > 6)
            {
                formatado += "." + numeros.Substring(6, Math.Min(3, numeros.Length - 6));
            }

            if (numeros.Length > 9)
            {
                formatado += "-" + numeros.Substring(9, Math.Min(2, numeros.Length - 9));
            }

            TBCPF.TextChanged -= TBCPF_TextChanged;

            TBCPF.Text = formatado;

            TBCPF.SelectionStart = TBCPF.Text.Length;

            TBCPF.TextChanged += TBCPF_TextChanged;
        }

        private void TBRG_TextChanged(object sender, EventArgs e)
        {
            string numeros = "";

            foreach (char c in TBRG.Text)
            {
                if (char.IsDigit(c))
                {
                    numeros += c;
                }
            }

            if (numeros.Length > 9)
            {
                numeros = numeros.Substring(0, 9);
            }

            string formatado = "";

            if (numeros.Length > 0)
            {
                formatado = numeros.Substring(0, Math.Min(2, numeros.Length));
            }

            if (numeros.Length > 2)
            {
                formatado += "." + numeros.Substring(2, Math.Min(3, numeros.Length - 2));
            }

            if (numeros.Length > 5)
            {
                formatado += "." + numeros.Substring(5, Math.Min(3, numeros.Length - 5));
            }

            if (numeros.Length > 8)
            {
                formatado += "-" + numeros.Substring(8, Math.Min(1, numeros.Length - 8));
            }

            TBRG.TextChanged -= TBRG_TextChanged;

            TBRG.Text = formatado;

            TBRG.SelectionStart = TBRG.Text.Length;

            TBRG.TextChanged += TBRG_TextChanged;
        }

        private bool UsuarioJaCadastrado()
        {
            SqlConnection conexao = Conexao.Conectar();

            string sql =
                "SELECT COUNT(*) FROM Cadastro WHERE CPF = @CPF OR RG = @RG";

            SqlCommand comando = new SqlCommand(sql, conexao);

            comando.Parameters.AddWithValue("@CPF", TBCPF.Text);
            comando.Parameters.AddWithValue("@RG", TBRG.Text);

            int total = Convert.ToInt32(comando.ExecuteScalar());

            conexao.Close();

            return total > 0;
        }

        private void BTAvancar_Click(object sender, EventArgs e)
        {
            if (DadosSistema.Modo != "Consultar")
            {
                bool cpfInvalido = TBCPF.Text.Length != 14;
                bool rgInvalido = TBRG.Text.Length != 12;

                if (cpfInvalido && rgInvalido)
                {
                    MessageBox.Show("Dados Inválidos");
                    return;
                }

                if (cpfInvalido)
                {
                    MessageBox.Show("CPF Inválido");
                    return;
                }

                if (rgInvalido)
                {
                    MessageBox.Show("RG Inválido");
                    return;
                }

                if (DadosSistema.Modo == "Cadastrar" && UsuarioJaCadastrado())
                {
                    MessageBox.Show("Usuário já cadastrado!");
                    return;
                }
            }

            DadosSistema.CPF = TBCPF.Text;
            DadosSistema.RG = TBRG.Text;

            Form3 tela3 = new Form3(this);
            tela3.Show();

            this.Hide();
        }
    }
}
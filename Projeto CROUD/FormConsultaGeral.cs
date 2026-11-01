using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Projeto_CROUD
{
    public partial class FormConsultaGeral : Form
    {
        public FormConsultaGeral()
        {
            InitializeComponent();

            BTVoltar.Click -= BTVoltar_Click;
            BTAtualizar.Click -= BTAtualizar_Click;

            BTVoltar.Click += BTVoltar_Click;
            BTAtualizar.Click += BTAtualizar_Click;

            CarregarAlunos();
        }

        private void CarregarAlunos()
        {
            SqlConnection conexao = Conexao.Conectar();

            string sql = "SELECT * FROM Cadastro ORDER BY Id";

            SqlDataAdapter adaptador =
                new SqlDataAdapter(sql, conexao);

            DataTable tabela = new DataTable();

            adaptador.Fill(tabela);

            DGVAlunos.DataSource = tabela;

            conexao.Close();

            DGVAlunos.ReadOnly = true;

            DGVAlunos.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;

            DGVAlunos.AutoResizeColumns();

            DGVAlunos.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            DGVAlunos.RowHeadersVisible = false;

            DGVAlunos.AllowUserToResizeColumns = false;
            DGVAlunos.AllowUserToResizeRows = false;
        }

        private void BTAtualizar_Click(object sender, EventArgs e)
        {
            CarregarAlunos();
        }

        private void BTVoltar_Click(object sender, EventArgs e)
        {
            FormIntroducao tela = new FormIntroducao();

            tela.Show();

            this.Close();
        }
    }
}
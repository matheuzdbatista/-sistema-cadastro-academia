using System;
using System.Data.SqlClient;

namespace Projeto_CROUD
{
    public static class Conexao
    {
        public static SqlConnection Conectar()
        {
            SqlConnection conexao = new SqlConnection(
                @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ProjetoCRUD;Integrated Security=True"
            );

            conexao.Open();
            return conexao;
        }

        public static int GerarProximoId()
        {
            SqlConnection conexao = Conectar();

            string sql = "SELECT ISNULL(MAX(Id), -1) + 1 FROM Cadastro";

            SqlCommand comando = new SqlCommand(sql, conexao);

            int proximoId = Convert.ToInt32(comando.ExecuteScalar());

            conexao.Close();

            return proximoId;
        }
    }
}
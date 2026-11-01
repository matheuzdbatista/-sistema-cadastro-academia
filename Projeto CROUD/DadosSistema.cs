using System.Collections.Generic;

namespace Projeto_CROUD
{
    public static class DadosSistema
    {
        public static int ProximoId = 0;

        public static int IdSelecionado = -1;

        public static List<int> IdsCadastrados =
            new List<int>();

        public static string Modo = "Cadastrar";

        public static string Nome = "";

        public static string Telefone = "";

        public static string Endereco = "";

        public static string CEP = "";

        public static string Cidade = "";

        public static string Estado = "";

        public static string Sexo = "";

        public static string DataNascimento = "";

        public static string CPF = "";

        public static string RG = "";
    }
}
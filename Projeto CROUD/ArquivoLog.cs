using System;
using System.IO;

namespace Projeto_CROUD
{
    public static class ArquivoLog
    {
        public static void Registrar(string acao)
        {
            string caminho = "log.txt";

            string mensagem = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") +
                              " - " + acao;

            File.AppendAllText(caminho, mensagem + Environment.NewLine);
        }
    }
}
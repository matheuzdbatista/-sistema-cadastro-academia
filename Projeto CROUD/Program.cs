using System;
using System.Windows.Forms;

namespace Projeto_CROUD
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new FormInicial());
        }
    }
}
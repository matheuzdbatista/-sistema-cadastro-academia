using System;
using System.Windows.Forms;

namespace Projeto_CROUD
{
    public partial class FormInicial : Form
    {
        public FormInicial()
        {
            InitializeComponent();

            BTEntrar.Click -= BTEntrar_Click;
            BTEntrar.Click += BTEntrar_Click;
        }

        private void BTEntrar_Click(object sender, EventArgs e)
        {
            FormIntroducao tela = new FormIntroducao();
            tela.Show();

            this.Hide();
        }
    }
}
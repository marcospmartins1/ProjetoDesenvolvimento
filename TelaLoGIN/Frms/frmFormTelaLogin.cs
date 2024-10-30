using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoDesenvolvimento.Classes;

namespace ProjetoDesenvolvimento.Frms
{
    public partial class FormTelaLogin : Form
    {
        public FormTelaLogin()
        {
            InitializeComponent();
        }
        private void informaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSobre FS = new FrmSobre();
            FS.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormTelaLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void informaçaoSobreOProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSobre2 FS = new FrmSobre2();
            FS.Show();
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            bool resultadoLogin = usuario.Login(txtLogin.Text, txtSenha.Text);

            if (resultadoLogin == true)
            {
                Frms.TelaPrincipal frm = new Frms.TelaPrincipal();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos!", "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}

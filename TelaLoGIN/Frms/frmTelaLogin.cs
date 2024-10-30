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
    /// <summary>
    /// 20190827-frmTelaLogin: TELA RESPONSÁVEL PELA AUTENTICAÇÃO DO USUÁRIO.
    /// </summary>
    public partial class frmTelaLogin : Form
    {
        /// <summary>
        /// 20190827-MetodoLogin: METODO PARA FAZER A AUTENTICAÇÃO DO USUÁRIO.
        /// </summary>
        public frmTelaLogin()
        {
            InitializeComponent();
        }
        private void informaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre FS = new frmSobre();
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
            frmSobre2 FS = new frmSobre2();
            FS.Show();
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            bool resultadoLogin = usuario.Login(txtLogin.Text, txtSenha.Text);

            if (resultadoLogin == true)
            {
                Frms.frmTelaPrincipal frm = new Frms.frmTelaPrincipal();
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

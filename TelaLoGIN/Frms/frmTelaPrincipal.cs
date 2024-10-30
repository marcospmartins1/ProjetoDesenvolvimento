using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoDesenvolvimento.Frms
{
    public partial class frmTelaPrincipal : Form
    {
        public frmTelaPrincipal()
        {
            InitializeComponent();
        }

        private void cadastrarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroClientes CC = new frmCadastroClientes();
            CC.Show();
        }

        private void trocarUsuárioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void trocarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTelaLogin TL = new frmTelaLogin();
            TL.Show();
        }

        private void TelaPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void informaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre FS = new frmSobre();
            FS.Show();
        }

        private void informaçãoSobreOProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre2 FS = new frmSobre2();
            FS.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToLongDateString();
            toolStripStatusLabel3.Text = DateTime.Now.ToLongTimeString();
        }

        private void cadastrarFornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frms.frmCadastroFornecedores frm = new  Frms.frmCadastroFornecedores();
            frm.Show();
        }

        private void cadastrarProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frms.frmCadastroProdutos frm = new Frms.frmCadastroProdutos();
            frm.Show();
        }

        private void cadastrarCategoriaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Frms.frmCadastroCategoria frm = new Frms.frmCadastroCategoria();
            frm.Show();
        }

        private void cadastrarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frms.frmCadastroUsuarios frm = new Frms.frmCadastroUsuarios();
            frm.Show();
        }

        private void listarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frms.frmListarClientes frm = new Frms.frmListarClientes();
            frm.Show();
        }

        private void listarCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frms.frmListarCategoria frm = new Frms.frmListarCategoria();
            frm.Show();
        }

        private void listarFornecedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frms.frmListarFornecedores frm = new Frms.frmListarFornecedores();
            frm.Show();
        }

        private void listarProdutosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frms.frmListarProdutos frm = new Frms.frmListarProdutos();
            frm.Show();
        }

        private void listarUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frms.frmListarUsuarios frm = new Frms.frmListarUsuarios();
            frm.Show();
        }
    }
}

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
    /// <summary>
    /// 20190830-frmListarUsuarios: TELA RESPONSÁVEL PELA LISTAGEM DOS DADOS CADASTRADO NA TABELA USUARIO.
    /// </summary>
    public partial class frmListarUsuarios : Form
    {
        public frmListarUsuarios()
        {
            InitializeComponent();
        }

        private void frmListarUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lojaecocostaDataSet14.Usuarios'. Você pode movê-la ou removê-la conforme necessário.
            this.usuariosTableAdapter.Fill(this.lojaecocostaDataSet14.Usuarios);

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Frms.frmCadastroUsuarios frm = new Frms.frmCadastroUsuarios();
            frm.Show();
            this.Close();
        }

        private void dataGridViewListarUsuarios_Click(object sender, EventArgs e)
        {
            Frms.frmCadastroUsuarios frm = new Frms.frmCadastroUsuarios();

            frm.txtID.Text = this.dataGridViewListarUsuarios.CurrentRow.Cells[0].Value.ToString();
            frm.TxtUsuario.Text = this.dataGridViewListarUsuarios.CurrentRow.Cells[1].Value.ToString();
            frm.txtSenha.Text = this.dataGridViewListarUsuarios.CurrentRow.Cells[2].Value.ToString();
            frm.txtEmail.Text = this.dataGridViewListarUsuarios.CurrentRow.Cells[3].Value.ToString();

            frm.Show();
            this.Close();
        }
    }
}

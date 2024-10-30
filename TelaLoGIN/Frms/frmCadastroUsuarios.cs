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
    public partial class frmCadastroUsuarios : Form
    {
        /// <summary>
        /// 20190830-CadastroUsuario: TELA RESPONSÁVEL PELO CADASTRO DE USUARIOS.
        /// </summary>
        public frmCadastroUsuarios()
        {
            InitializeComponent();
            TxtUsuario.Focus();
        }

        private void frmCadastroUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lojaecocostaDataSet10.Usuarios'. Você pode movê-la ou removê-la conforme necessário.
            this.usuariosTableAdapter.Fill(this.lojaecocostaDataSet10.Usuarios);

        }

        private void dataGridViewUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = this.dataGridViewUsuarios.CurrentRow.Cells[0].Value.ToString();
            TxtUsuario.Text = this.dataGridViewUsuarios.CurrentRow.Cells[1].Value.ToString();
            txtSenha.Text = this.dataGridViewUsuarios.CurrentRow.Cells[2].Value.ToString();
            txtEmail.Text = this.dataGridViewUsuarios.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtUsuario.Text) ||
                 string.IsNullOrEmpty(txtSenha.Text) ||
                 string.IsNullOrEmpty(txtConfirmarSenha.Text) ||
                 string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Erro! Não deixe os campos em brancos.", "Houve um erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtSenha.Text == txtConfirmarSenha.Text)
            {
                Classes.Usuario usuario = new Classes.Usuario();

                int resultadoCadastrar = usuario.CadastrarUsuario(TxtUsuario.Text, txtSenha.Text, txtEmail.Text);
                if (resultadoCadastrar == 1)
                {
                    MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtID.Clear();
                    TxtUsuario.Clear();
                    txtSenha.Clear();
                    txtConfirmarSenha.Clear();
                    txtEmail.Clear();
                }
                else
                {
                    MessageBox.Show("Erro \n Não foi possível cadastrar o usuário.", "Houve um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.usuariosTableAdapter.Fill(this.lojaecocostaDataSet10.Usuarios);
            }
            else
            {
                MessageBox.Show("Erro! Senhas não conferem.", "Houve um erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtUsuario.Text) ||
                string.IsNullOrEmpty(txtSenha.Text) ||
                string.IsNullOrEmpty(txtConfirmarSenha.Text) ||
                string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Erro! Não deixe os campos em brancos.", "Houve um erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtSenha.Text == txtConfirmarSenha.Text)
            {
                Classes.Usuario usuario = new Classes.Usuario();

                int resultadoAtualizar = usuario.AtualizarUsuario(TxtUsuario.Text, txtSenha.Text, txtEmail.Text, txtID.Text);

                if (resultadoAtualizar == 1)
                {
                    MessageBox.Show("Dados atualizado com sucesso.", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtID.Clear();
                    TxtUsuario.Clear();
                    txtSenha.Clear();
                    txtConfirmarSenha.Clear();
                    txtEmail.Clear();
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro. Não foi possível atualizar os dados.", "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.usuariosTableAdapter.Fill(this.lojaecocostaDataSet10.Usuarios);
            }
            else
            {
                MessageBox.Show("Erro! Senhas não conferem.", "Houve um erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            Classes.Usuario usuario = new Classes.Usuario();

                int resultadoDeletar = usuario.DeletarUsuario(txtID.Text);
                if (resultadoDeletar == 1)
                {
                    MessageBox.Show("Usuario deletado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtID.Clear();
                    TxtUsuario.Clear();
                    txtSenha.Clear();
                    txtEmail.Clear();
                }

                this.usuariosTableAdapter.Fill(this.lojaecocostaDataSet10.Usuarios);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void informaçãoSobreODesenvolvimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre FS = new frmSobre();
            FS.Show();
        }

        private void informaçãoSobreOProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre2 FS = new frmSobre2();
            FS.Show();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Frms.frmListarUsuarios frm = new Frms.frmListarUsuarios();
            frm.Show();
            this.Close();
        }

        private void listarUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frms.frmListarUsuarios frm = new Frms.frmListarUsuarios();
            frm.Show();
        }
    }
}

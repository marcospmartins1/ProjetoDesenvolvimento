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
    /// 20190829-frmCadastroCategoria: TELA RESPONSÁVEL PELO CADASTRO DE CATEGORIAS.
    /// </summary>
    public partial class frmCadastroCategoria : Form
    {
        public frmCadastroCategoria()
        {
            InitializeComponent();
            txtNomecategoria.Focus();
        }

        private void frmCadastroCategoria_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lojaecocostaDataSet8.Categoria'. Você pode movê-la ou removê-la conforme necessário.
            this.categoriaTableAdapter.Fill(this.lojaecocostaDataSet8.Categoria);

        }
        private void dataGridViewCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = this.dataGridViewCategoria.CurrentRow.Cells[0].Value.ToString();
            txtNomecategoria.Text = this.dataGridViewCategoria.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNomecategoria.Text))
            {
                MessageBox.Show("Erro! Não deixe os campos em brancos.", "Houve um erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Classes.Categoria categoria = new Classes.Categoria();

                int resultadoCadastrar = categoria.CadastrarCategoria(txtNomecategoria.Text);
                if (resultadoCadastrar == 1)
                {
                    MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtID.Clear();
                    txtNomecategoria.Clear();
                }
                else
                {
                    MessageBox.Show("Erro \n Não foi possível cadastrar a Categoria.", "Houve um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.categoriaTableAdapter.Fill(this.lojaecocostaDataSet8.Categoria);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNomecategoria.Text))
            {
                MessageBox.Show("Erro! Não deixe os campos em brancos.", "Houve um erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Classes.Categoria categoria = new Classes.Categoria();

                int resultadoAtualizar = categoria.AtualizarCategoria(txtNomecategoria.Text, txtID.Text);
                if (resultadoAtualizar == 1)
                {
                    MessageBox.Show("Dados atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtID.Clear();
                    txtNomecategoria.Clear();
                }
                else
                {
                    MessageBox.Show("Erro \n Não foi possível atualizar os dados.", "Houve um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.categoriaTableAdapter.Fill(this.lojaecocostaDataSet8.Categoria);
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
                Classes.Categoria categoria = new Classes.Categoria();

                int resultadoDeletar = categoria.DeletarCategoria(txtID.Text);

                if (resultadoDeletar == 1)
                {
                    MessageBox.Show("Categoria deletada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtID.Clear();
                    txtNomecategoria.Clear();
                }
                else
                {
                    MessageBox.Show("Erro! Nenhuma categoria foi selecionada.", "Houve um erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                this.categoriaTableAdapter.Fill(this.lojaecocostaDataSet8.Categoria);            
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Frms.frmListarCategoria frm = new Frms.frmListarCategoria();
            frm.Show();
            this.Close();
        }

        private void listarProdutosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frms.frmListarCategoria frm = new Frms.frmListarCategoria();
            frm.Show();
        }
    }
}

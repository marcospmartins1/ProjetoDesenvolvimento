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
    /// 20190828-frmCadastroProdutos: TELA RESPONSÁVEL PELO CADASTRO DE PRODUTOS
    /// </summary>
    public partial class frmCadastroProdutos : Form
    {
        public frmCadastroProdutos()
        {
            InitializeComponent();
            txtNomeProduto.Focus();
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

        private void frmCadastroProdutos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lojaecocostaDataSet9.Categoria'. Você pode movê-la ou removê-la conforme necessário.
            this.categoriaTableAdapter.Fill(this.lojaecocostaDataSet9.Categoria);
            // TODO: esta linha de código carrega dados na tabela 'lojaecocostaDataSet7.Fornecedores'. Você pode movê-la ou removê-la conforme necessário.
            this.fornecedoresTableAdapter1.Fill(this.lojaecocostaDataSet7.Fornecedores);
            // TODO: esta linha de código carrega dados na tabela 'lojaecocostaDataSet6.Produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosTableAdapter.Fill(this.lojaecocostaDataSet6.Produtos);

        }

        private void dataGridViewProdutos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = this.dataGridViewProdutos.CurrentRow.Cells[0].Value.ToString();
            txtNomeProduto.Text = this.dataGridViewProdutos.CurrentRow.Cells[1].Value.ToString();
            comboCategoria.Text = this.dataGridViewProdutos.CurrentRow.Cells[2].Value.ToString();
            txtDescricao.Text = this.dataGridViewProdutos.CurrentRow.Cells[3].Value.ToString();
            comboFornecedor.Text = this.dataGridViewProdutos.CurrentRow.Cells[4].Value.ToString();
            txtQuantidade.Text = this.dataGridViewProdutos.CurrentRow.Cells[5].Value.ToString();
            double valor = Convert.ToDouble(string.Format("{0}", this.dataGridViewProdutos.CurrentRow.Cells[6].Value));
            txtValor.Text = string.Format("{0:n2}", valor);
            double valorbruto = Convert.ToDouble(string.Format("{0}", this.dataGridViewProdutos.CurrentRow.Cells[7].Value));
            txtValorBruto.Text = string.Format("{0:n2}", valorbruto);
        }



        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNomeProduto.Text) ||
                string.IsNullOrEmpty(comboCategoria.Text) ||
                string.IsNullOrEmpty(txtDescricao.Text) ||
                string.IsNullOrEmpty(comboFornecedor.Text) ||
                string.IsNullOrEmpty(txtQuantidade.Text) ||
                string.IsNullOrEmpty(txtValor.Text) ||
                string.IsNullOrEmpty(txtValorBruto.Text))
            {
                MessageBox.Show("Erro! Não deixe os campos em brancos.", "Houve um erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Classes.Produtos produtos = new Classes.Produtos();

                int resultadoCadastrar = produtos.CadastrarProdutos(txtNomeProduto.Text, comboCategoria.Text, txtDescricao.Text, comboFornecedor.Text, txtQuantidade.Text, txtValor.Text, txtValorBruto.Text);

                if (resultadoCadastrar == 1)
                {
                    MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtID.Clear();
                    txtNomeProduto.Clear();
                    txtDescricao.Clear(); ;
                    txtQuantidade.Clear();
                    txtValor.Clear();
                    txtValorBruto.Clear();
                }
                else
                {
                    MessageBox.Show("Erro não foi possível cadastrar o produto.", "Houve um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.produtosTableAdapter.Fill(this.lojaecocostaDataSet6.Produtos);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNomeProduto.Text) ||
                string.IsNullOrEmpty(comboCategoria.Text) ||
                string.IsNullOrEmpty(txtDescricao.Text) ||
                string.IsNullOrEmpty(comboFornecedor.Text) ||
                string.IsNullOrEmpty(txtQuantidade.Text) ||
                string.IsNullOrEmpty(txtValor.Text) ||
                string.IsNullOrEmpty(txtValorBruto.Text))
            {
                MessageBox.Show("Erro! Não deixe os campos em brancos.", "Houve um erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Classes.Produtos produtos = new Classes.Produtos();

                int resultadoAtualizar = produtos.AtualizarProduto(txtNomeProduto.Text, comboCategoria.Text, txtDescricao.Text, comboFornecedor.Text, txtQuantidade.Text, txtValor.Text, txtValorBruto.Text, txtID.Text);
                if (resultadoAtualizar == 1)
                {
                    MessageBox.Show("Dados atualizado com sucesso.", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtID.Clear();
                    txtNomeProduto.Clear();
                    txtDescricao.Clear(); ;
                    txtQuantidade.Clear();
                    txtValor.Clear();
                    txtValorBruto.Clear();
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro. Não foi possível atualizar os dados.", "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.produtosTableAdapter.Fill(this.lojaecocostaDataSet6.Produtos);
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {     

                Classes.Produtos produtos = new Classes.Produtos();
                int resultadoDeletar = produtos.DeletarProdutos(txtID.Text);

                if (resultadoDeletar == 1)
                {
                    MessageBox.Show("Produto deletado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtID.Clear();
                    txtNomeProduto.Clear();
                    txtDescricao.Clear(); ;
                    txtQuantidade.Clear();
                    txtValor.Clear();
                    txtValorBruto.Clear();
                }
                else
                {
                    MessageBox.Show("Erro! Nenhum fornecedor foi selecionado.", "Houve um erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                this.produtosTableAdapter.Fill(this.lojaecocostaDataSet6.Produtos);            
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Frms.frmListarProdutos frm = new Frms.frmListarProdutos();
            frm.Show();
            this.Close();
        }

        private void listarProdutosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frms.frmListarProdutos frm = new Frms.frmListarProdutos();
            frm.Show();
        }        
            
        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtValor.Text))
            {
                txtValor.Text = "0";
            }
            else if(string.IsNullOrEmpty(txtQuantidade.Text))
            {
                txtQuantidade.Text = "0";
            }
            else
            {
                double resultado, quantidade, valor;

                valor = Convert.ToDouble(txtValor.Text);
                quantidade = Convert.ToDouble(txtQuantidade.Text);

                resultado = (valor * quantidade);
                txtValorBruto.Text = resultado.ToString();
            }
        }

        
    }
}

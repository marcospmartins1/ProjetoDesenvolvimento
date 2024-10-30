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
    public partial class frmListarProdutos : Form
    {
        /// <summary>
        /// 20190830-frmListarProdutos: TELA RESPONSÁVEL PELA LISTAGEM DOS DADOS CADASTRADO NA TABELA PRODUTOS.
        /// </summary>
        public frmListarProdutos()
        {
            InitializeComponent();
        }

        private void frmListarProdutos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lojaecocostaDataSet15.Produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosTableAdapter.Fill(this.lojaecocostaDataSet15.Produtos);

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Frms.frmCadastroProdutos frm = new Frms.frmCadastroProdutos();
            frm.Show();
            this.Close();
        }

        private void dataGridViewListarProdutos_Click(object sender, EventArgs e)
        {
            Frms.frmCadastroProdutos frm = new Frms.frmCadastroProdutos();

            frm.txtID.Text = this.dataGridViewListarProdutos.CurrentRow.Cells[0].Value.ToString();
            frm.txtNomeProduto.Text = this.dataGridViewListarProdutos.CurrentRow.Cells[1].Value.ToString();
            frm.comboCategoria.Text = this.dataGridViewListarProdutos.CurrentRow.Cells[2].Value.ToString();
            frm.txtDescricao.Text = this.dataGridViewListarProdutos.CurrentRow.Cells[3].Value.ToString();
            frm.comboFornecedor.Text = this.dataGridViewListarProdutos.CurrentRow.Cells[4].Value.ToString();
            frm.txtQuantidade.Text = this.dataGridViewListarProdutos.CurrentRow.Cells[5].Value.ToString();
            frm.txtValor.Text = this.dataGridViewListarProdutos.CurrentRow.Cells[6].Value.ToString();
            frm.txtValorBruto.Text = this.dataGridViewListarProdutos.CurrentRow.Cells[7].Value.ToString();

            frm.Show();
            this.Close();
        }
    }
}

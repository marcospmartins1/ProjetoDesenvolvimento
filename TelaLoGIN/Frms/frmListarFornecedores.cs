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
    public partial class frmListarFornecedores : Form
    {
        /// <summary>
        /// 20190830-frmListarFornecedores: TELA RESPONSÁVEL PELA LISTAGEM DOS DADOS CADASTRADO NA TABELA FORNECEDORES.
        /// </summary>
        public frmListarFornecedores()
        {
            InitializeComponent();
        }

        private void frmListarFornecedores_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lojaecocostaDataSet12.Fornecedores'. Você pode movê-la ou removê-la conforme necessário.
            this.fornecedoresTableAdapter.Fill(this.lojaecocostaDataSet12.Fornecedores);

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Frms.frmCadastroFornecedores frm = new Frms.frmCadastroFornecedores();
            frm.Show();
            this.Close();
        }

        private void dataGridViewListarFornecedores_Click(object sender, EventArgs e)
        {
            Frms.frmCadastroFornecedores frm = new Frms.frmCadastroFornecedores();

            frm.txtID.Text = this.dataGridViewListarFornecedores.CurrentRow.Cells[0].Value.ToString();
            frm.txtNomeFornecedor.Text = this.dataGridViewListarFornecedores.CurrentRow.Cells[1].Value.ToString();
            frm.maskedcnpj.Text = this.dataGridViewListarFornecedores.CurrentRow.Cells[2].Value.ToString();
            frm.maskeddata.Text = this.dataGridViewListarFornecedores.CurrentRow.Cells[3].Value.ToString();
            frm.comboSexo.Text = this.dataGridViewListarFornecedores.CurrentRow.Cells[4].Value.ToString();
            frm.maskedcelular.Text = this.dataGridViewListarFornecedores.CurrentRow.Cells[5].Value.ToString();
            frm.maskedresidencial.Text = this.dataGridViewListarFornecedores.CurrentRow.Cells[6].Value.ToString();
            frm.txtemail.Text = this.dataGridViewListarFornecedores.CurrentRow.Cells[7].Value.ToString();
            frm.txtEndereco.Text = this.dataGridViewListarFornecedores.CurrentRow.Cells[8].Value.ToString();
            frm.txtNumeroCasa.Text = this.dataGridViewListarFornecedores.CurrentRow.Cells[9].Value.ToString();
            frm.txtBairro.Text = this.dataGridViewListarFornecedores.CurrentRow.Cells[10].Value.ToString();
            frm.maskedCEP.Text = this.dataGridViewListarFornecedores.CurrentRow.Cells[11].Value.ToString();
            frm.comboEstado.Text = this.dataGridViewListarFornecedores.CurrentRow.Cells[12].Value.ToString();

            frm.Show();
            this.Close();
        }
    }
}

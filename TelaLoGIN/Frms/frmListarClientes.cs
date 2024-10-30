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
    public partial class frmListarClientes : Form
    {
        /// <summary>
        /// 20190830-frmListarClientes: TELA RESPONSÁVEL PELA LISTAGEM DOS DADOS CADASTRADO NA TABELA CLIENTES.
        /// </summary>
        public frmListarClientes()
        {
            InitializeComponent();
        }

        private void frmListarClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lojaecocostaDataSet11.Clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.clientesTableAdapter.Fill(this.lojaecocostaDataSet11.Clientes);

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Frms.frmCadastroClientes frm = new Frms.frmCadastroClientes();
            frm.Show();
            this.Close();
        }
        private void dataGridViewListarClientes_Click(object sender, EventArgs e)
        {
            Frms.frmCadastroClientes frm = new Frms.frmCadastroClientes();

            frm.txtID.Text = this.dataGridViewListarClientes.CurrentRow.Cells[0].Value.ToString();
            frm.txtNomeCliente.Text = this.dataGridViewListarClientes.CurrentRow.Cells[1].Value.ToString();
            frm.maskedcpf.Text = this.dataGridViewListarClientes.CurrentRow.Cells[2].Value.ToString();
            frm.maskedrg.Text = this.dataGridViewListarClientes.CurrentRow.Cells[3].Value.ToString();
            frm.maskeddata.Text = this.dataGridViewListarClientes.CurrentRow.Cells[4].Value.ToString();
            frm.comboSexo.Text = this.dataGridViewListarClientes.CurrentRow.Cells[5].Value.ToString();
            frm.maskedTelefonecelular.Text = this.dataGridViewListarClientes.CurrentRow.Cells[6].Value.ToString();
            frm.maskedTelefoneresidencial.Text = this.dataGridViewListarClientes.CurrentRow.Cells[7].Value.ToString();
            frm.txtEMAIL.Text = this.dataGridViewListarClientes.CurrentRow.Cells[8].Value.ToString();
            frm.txtEndereco.Text = this.dataGridViewListarClientes.CurrentRow.Cells[9].Value.ToString();
            frm.txtNumeroCasa.Text = this.dataGridViewListarClientes.CurrentRow.Cells[10].Value.ToString();
            frm.txtBairro.Text = this.dataGridViewListarClientes.CurrentRow.Cells[11].Value.ToString();
            frm.maskedCEP.Text = this.dataGridViewListarClientes.CurrentRow.Cells[12].Value.ToString();
            frm.comboEstado.Text = this.dataGridViewListarClientes.CurrentRow.Cells[13].Value.ToString();

            this.Close();
            frm.Show();
        }
    }
}

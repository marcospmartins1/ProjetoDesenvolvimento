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
    public partial class frmListarCategoria : Form
    {
        /// <summary>
        /// 20190830-frmListarCategoria: TELA RESPONSÁVEL PELA LISTAGEM DOS DADOS CADASTRADO NA TABELA CATEGORIA.
        /// </summary>
        public frmListarCategoria()
        {
            InitializeComponent();
        }

        private void frmListarCategoria_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lojaecocostaDataSet13.Categoria'. Você pode movê-la ou removê-la conforme necessário.
            this.categoriaTableAdapter.Fill(this.lojaecocostaDataSet13.Categoria);

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Frms.frmCadastroCategoria frm = new Frms.frmCadastroCategoria();
            frm.Show();
            this.Close();
        }

        private void dataGridViewListarCategorias_Click(object sender, EventArgs e)
        {
            Frms.frmCadastroCategoria frm = new Frms.frmCadastroCategoria();

            frm.txtID.Text = this.dataGridViewListarCategorias.CurrentRow.Cells[0].Value.ToString();
            frm.txtNomecategoria.Text = this.dataGridViewListarCategorias.CurrentRow.Cells[1].Value.ToString();

            this.Close();
            frm.Show();
        }
    }
}

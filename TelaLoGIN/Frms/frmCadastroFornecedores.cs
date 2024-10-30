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
    /// 20190828-frmCadastroFornecedores: TELA RESPONSÁVEL PELO CADASTRO DE FORNECEDORES.
    /// </summary>
    public partial class frmCadastroFornecedores : Form
    {
        public frmCadastroFornecedores()
        {
            InitializeComponent();
            txtNomeFornecedor.Focus();
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

        private void frmCadastroFornecedores_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lojaecocostaDataSet1.Fornecedores'. Você pode movê-la ou removê-la conforme necessário.
            this.fornecedoresTableAdapter.Fill(this.lojaecocostaDataSet1.Fornecedores);

        }
        private void dataGridViewFornecedores_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = this.dataGridViewFornecedores.CurrentRow.Cells[0].Value.ToString();
            txtNomeFornecedor.Text = this.dataGridViewFornecedores.CurrentRow.Cells[1].Value.ToString();
            maskedcnpj.Text = this.dataGridViewFornecedores.CurrentRow.Cells[2].Value.ToString();
            maskeddata.Text = this.dataGridViewFornecedores.CurrentRow.Cells[3].Value.ToString();
            comboSexo.Text = this.dataGridViewFornecedores.CurrentRow.Cells[4].Value.ToString();
            maskedcelular.Text = this.dataGridViewFornecedores.CurrentRow.Cells[5].Value.ToString();
            maskedresidencial.Text = this.dataGridViewFornecedores.CurrentRow.Cells[6].Value.ToString();
            txtemail.Text = this.dataGridViewFornecedores.CurrentRow.Cells[7].Value.ToString();
            txtEndereco.Text = this.dataGridViewFornecedores.CurrentRow.Cells[8].Value.ToString();
            txtNumeroCasa.Text = this.dataGridViewFornecedores.CurrentRow.Cells[9].Value.ToString();
            txtBairro.Text = this.dataGridViewFornecedores.CurrentRow.Cells[10].Value.ToString();
            maskedCEP.Text = this.dataGridViewFornecedores.CurrentRow.Cells[11].Value.ToString();
            comboEstado.Text = this.dataGridViewFornecedores.CurrentRow.Cells[12].Value.ToString();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNomeFornecedor.Text) ||
                string.IsNullOrEmpty(maskedcnpj.Text) ||
                string.IsNullOrEmpty(maskeddata.Text) ||
                string.IsNullOrEmpty(comboSexo.Text) ||
                string.IsNullOrEmpty(maskedcelular.Text) ||
                string.IsNullOrEmpty(txtemail.Text) ||
                string.IsNullOrEmpty(txtEndereco.Text) ||
                string.IsNullOrEmpty(txtNumeroCasa.Text) ||
                string.IsNullOrEmpty(txtBairro.Text) ||
                string.IsNullOrEmpty(maskedCEP.Text) ||
                string.IsNullOrEmpty(comboEstado.Text))
            {
                MessageBox.Show("Erro! Não deixe os campos em brancos.", "Houve um erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Classes.Fornecedores fornecedores = new Classes.Fornecedores();

                maskedcnpj.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string cnpj = maskedcnpj.Text;
                maskedcnpj.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

                maskeddata.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string data = maskeddata.Text;
                maskeddata.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

                maskedcelular.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string telefonecelular = maskedcelular.Text;
                maskedcelular.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

                maskedresidencial.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string telefoneresidencial = maskedresidencial.Text;
                maskedresidencial.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

                maskedCEP.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string cep = maskedCEP.Text;
                maskedCEP.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

                int resultadoCadastrar = fornecedores.CadastrarFornecedores(txtNomeFornecedor.Text, cnpj, data, comboSexo.Text, telefonecelular, telefoneresidencial, txtemail.Text, txtEndereco.Text, txtNumeroCasa.Text, txtBairro.Text, cep, comboEstado.Text);

                if (resultadoCadastrar == 1)
                {
                    MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro \n Não foi possível cadastrar o fornecedor.", "Houve um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                txtID.Clear();
                txtNomeFornecedor.Clear();
                maskedcnpj.Clear();
                maskeddata.Clear();
                maskedcelular.Clear();
                maskedresidencial.Clear();
                txtemail.Clear();
                txtEndereco.Clear();
                txtNumeroCasa.Clear();
                txtBairro.Clear();
                maskedCEP.Clear();

                this.fornecedoresTableAdapter.Fill(this.lojaecocostaDataSet1.Fornecedores);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNomeFornecedor.Text) ||
                string.IsNullOrEmpty(maskedcnpj.Text) ||
                string.IsNullOrEmpty(maskeddata.Text) ||
                string.IsNullOrEmpty(comboSexo.Text) ||
                string.IsNullOrEmpty(maskedcelular.Text) ||
                string.IsNullOrEmpty(txtemail.Text) ||
                string.IsNullOrEmpty(txtEndereco.Text) ||
                string.IsNullOrEmpty(txtNumeroCasa.Text) ||
                string.IsNullOrEmpty(txtBairro.Text) ||
                string.IsNullOrEmpty(maskedCEP.Text) ||
                string.IsNullOrEmpty(comboEstado.Text))
            {
                MessageBox.Show("Erro! Não deixe os campos em brancos.", "Houve um erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Classes.Fornecedores fornecedores = new Classes.Fornecedores();

                maskedcnpj.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string cnpj = maskedcnpj.Text;
                maskedcnpj.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

                maskeddata.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string data = maskeddata.Text;
                maskeddata.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

                maskedcelular.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string telefonecelular = maskedcelular.Text;
                maskedcelular.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

                maskedresidencial.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string telefoneresidencial = maskedresidencial.Text;
                maskedresidencial.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

                maskedCEP.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string cep = maskedCEP.Text;
                maskedCEP.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

                int resultadoAtualizar = fornecedores.AtualizarFornecedor(txtNomeFornecedor.Text, cnpj, data, comboSexo.Text, telefonecelular, telefoneresidencial, txtemail.Text, txtEndereco.Text, txtNumeroCasa.Text, txtBairro.Text, cep, comboEstado.Text, txtID.Text);

                if (resultadoAtualizar == 1)
                {
                    MessageBox.Show("Dados atualizado com sucesso.", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro. Não foi possível atualizar os dados.", "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                txtID.Clear();
                txtNomeFornecedor.Clear();
                maskedcnpj.Clear();
                maskeddata.Clear();
                maskedcelular.Clear();
                maskedresidencial.Clear();
                txtemail.Clear();
                txtEndereco.Clear();
                txtNumeroCasa.Clear();
                txtBairro.Clear();
                maskedCEP.Clear();

                this.fornecedoresTableAdapter.Fill(this.lojaecocostaDataSet1.Fornecedores);
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
                Classes.Fornecedores fornecedores = new Classes.Fornecedores();

                maskedcnpj.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string cnpj = maskedcnpj.Text;
                maskedcnpj.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

                maskeddata.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string data = maskeddata.Text;
                maskeddata.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

                maskedcelular.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string telefonecelular = maskedcelular.Text;
                maskedcelular.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

                maskedresidencial.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string telefoneresidencial = maskedresidencial.Text;
                maskedresidencial.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

                maskedCEP.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string cep = maskedCEP.Text;
                maskedCEP.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

                int resultadoDeletar = fornecedores.DeletarFornecedores(txtID.Text);

                if (resultadoDeletar == 1)
                {
                    MessageBox.Show("Fornecedor deletado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro! Nenhum fornecedor foi selecionado.", "Houve um erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                txtID.Clear();
                txtNomeFornecedor.Clear();
                maskedcnpj.Clear();
                maskeddata.Clear();
                maskedcelular.Clear();
                maskedresidencial.Clear();
                txtemail.Clear();
                txtEndereco.Clear();
                txtNumeroCasa.Clear();
                txtBairro.Clear();
                maskedCEP.Clear();

                this.fornecedoresTableAdapter.Fill(this.lojaecocostaDataSet1.Fornecedores);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Frms.frmListarFornecedores frm = new Frms.frmListarFornecedores();
            frm.Show();
            this.Close();
        }

        private void listarFornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frms.frmListarFornecedores frm = new Frms.frmListarFornecedores();
            frm.Show();
        }

        private void maskeddata_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
                MessageBox.Show("Data inválida");
        }
    }
}

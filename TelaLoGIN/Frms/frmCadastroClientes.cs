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
    /// 20190827-frmCadastroClientes: TELA RESPONSÁVEL PELO CADASTRO DE CLIENTES
    /// </summary>
    public partial class frmCadastroClientes : Form
    {
        public frmCadastroClientes()
        {
            InitializeComponent();
            txtNomeCliente.Focus();
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
        private void frmCadastroClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lojaecocostaDataSet.Clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.clientesTableAdapter.Fill(this.lojaecocostaDataSet.Clientes);
            txtNomeCliente.Focus();
        }

        private void dataGridViewClientes_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = this.dataGridViewClientes.CurrentRow.Cells[0].Value.ToString();
            txtNomeCliente.Text = this.dataGridViewClientes.CurrentRow.Cells[1].Value.ToString();
            maskedcpf.Text = this.dataGridViewClientes.CurrentRow.Cells[2].Value.ToString();
            maskedrg.Text = this.dataGridViewClientes.CurrentRow.Cells[3].Value.ToString();
            maskeddata.Text = this.dataGridViewClientes.CurrentRow.Cells[4].Value.ToString();
            comboSexo.Text = this.dataGridViewClientes.CurrentRow.Cells[5].Value.ToString();
            maskedTelefonecelular.Text = this.dataGridViewClientes.CurrentRow.Cells[6].Value.ToString();
            maskedTelefoneresidencial.Text = this.dataGridViewClientes.CurrentRow.Cells[7].Value.ToString();
            txtEMAIL.Text = this.dataGridViewClientes.CurrentRow.Cells[8].Value.ToString();
            txtEndereco.Text = this.dataGridViewClientes.CurrentRow.Cells[9].Value.ToString();
            txtNumeroCasa.Text = this.dataGridViewClientes.CurrentRow.Cells[10].Value.ToString();
            txtBairro.Text = this.dataGridViewClientes.CurrentRow.Cells[11].Value.ToString();
            maskedCEP.Text = this.dataGridViewClientes.CurrentRow.Cells[12].Value.ToString();
            comboEstado.Text = this.dataGridViewClientes.CurrentRow.Cells[13].Value.ToString();
        }

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNomeCliente.Text) ||
                string.IsNullOrEmpty(maskedcpf.Text) ||
                string.IsNullOrEmpty(maskedrg.Text) ||
                string.IsNullOrEmpty(maskeddata.Text) ||
                string.IsNullOrEmpty(comboSexo.Text) ||
                string.IsNullOrEmpty(maskedTelefonecelular.Text) ||
                string.IsNullOrEmpty(txtEMAIL.Text) ||
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
                Classes.Clientes clientes = new Classes.Clientes();

                maskedcpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string cpf = maskedcpf.Text;
                maskedcpf.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

                maskedrg.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string rg = maskedrg.Text;
                maskedrg.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

                maskeddata.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string data = maskeddata.Text;
                maskeddata.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

                maskedTelefonecelular.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string telefonecelular = maskedTelefonecelular.Text;
                maskedTelefonecelular.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

                maskedTelefoneresidencial.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string telefoneresidencial = maskedTelefoneresidencial.Text;
                maskedTelefoneresidencial.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

                maskedCEP.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string cep = maskedCEP.Text;
                maskedCEP.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

                int resultadoCadastrar = clientes.CadastrarCliente(txtNomeCliente.Text, cpf, rg, data, comboSexo.Text, telefonecelular, telefoneresidencial, txtEMAIL.Text, txtEndereco.Text, txtNumeroCasa.Text, txtBairro.Text, cep, comboEstado.Text);

                if (resultadoCadastrar == 1)
                {
                    MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtID.Clear();
                    txtNomeCliente.Clear();
                    maskedcpf.Clear();
                    maskedrg.Clear();
                    maskeddata.Clear();
                    maskedTelefonecelular.Clear();
                    maskedTelefoneresidencial.Clear();
                    txtEMAIL.Clear();
                    txtEndereco.Clear();
                    txtNumeroCasa.Clear();
                    txtBairro.Clear();
                    maskedCEP.Clear();
                }
                else
                {
                    MessageBox.Show("Erro \n Não foi possível cadastrar o cliente.", "Houve um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.clientesTableAdapter.Fill(this.lojaecocostaDataSet.Clientes);
            }
        }

        private void btnAtualizar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNomeCliente.Text) ||
               string.IsNullOrEmpty(maskedcpf.Text) ||
               string.IsNullOrEmpty(maskedrg.Text) ||
               string.IsNullOrEmpty(maskeddata.Text) ||
               string.IsNullOrEmpty(comboSexo.Text) ||
               string.IsNullOrEmpty(maskedTelefonecelular.Text) ||
               string.IsNullOrEmpty(txtEMAIL.Text) ||
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
                Classes.Clientes clientes = new Classes.Clientes();

                maskedcpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string cpf = maskedcpf.Text;
                maskedcpf.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

                maskedrg.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string rg = maskedrg.Text;
                maskedrg.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

                maskeddata.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string data = maskeddata.Text;
                maskeddata.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

                maskedTelefonecelular.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string telefonecelular = maskedTelefonecelular.Text;
                maskedTelefonecelular.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

                maskedTelefoneresidencial.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string telefoneresidencial = maskedTelefoneresidencial.Text;
                maskedTelefoneresidencial.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

                maskedCEP.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string cep = maskedCEP.Text;
                maskedCEP.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

                int resultadoAtualizar = clientes.AtualizarCliente(txtNomeCliente.Text, cpf, rg, data, comboSexo.Text, telefonecelular, telefoneresidencial, txtEMAIL.Text, txtEndereco.Text, txtNumeroCasa.Text, txtBairro.Text, cep, comboEstado.Text, txtID.Text);

                if (resultadoAtualizar == 1)
                {
                    MessageBox.Show("Dados atualizado com sucesso.", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtID.Clear();
                    txtNomeCliente.Clear();
                    maskedcpf.Clear();
                    maskedrg.Clear();
                    maskeddata.Clear();
                    maskedTelefonecelular.Clear();
                    maskedTelefoneresidencial.Clear();
                    txtEMAIL.Clear();
                    txtEndereco.Clear();
                    txtNumeroCasa.Clear();
                    txtBairro.Clear();
                    maskedCEP.Clear();
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro. Não foi possível atualizar os dados.", "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.clientesTableAdapter.Fill(this.lojaecocostaDataSet.Clientes);
            }
        }

        private void btnDeletar_Click_1(object sender, EventArgs e)
        {
                Classes.Clientes clientes = new Classes.Clientes();

                maskedcpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string cpf = maskedcpf.Text;
                maskedcpf.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

                maskedrg.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string rg = maskedrg.Text;
                maskedrg.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

                maskeddata.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string data = maskeddata.Text;
                maskeddata.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

                maskedTelefonecelular.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string telefonecelular = maskedTelefonecelular.Text;
                maskedTelefonecelular.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

                maskedTelefoneresidencial.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string telefoneresidencial = maskedTelefoneresidencial.Text;
                maskedTelefoneresidencial.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

                maskedCEP.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string cep = maskedCEP.Text;
                maskedCEP.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

                int resultadoDeletar = clientes.DeletarCliente(txtID.Text);

                if (resultadoDeletar == 1)
                {
                    MessageBox.Show("Cliente deletado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtID.Clear();
                    txtNomeCliente.Clear();
                    maskedcpf.Clear();
                    maskedrg.Clear();
                    maskeddata.Clear();
                    maskedTelefonecelular.Clear();
                    maskedTelefoneresidencial.Clear();
                    txtEMAIL.Clear();
                    txtEndereco.Clear();
                    txtNumeroCasa.Clear();
                    txtBairro.Clear();
                    maskedCEP.Clear();
                }
                else
                {
                    MessageBox.Show("Erro! Nenhum cliente foi selecionado.", "Houve um erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                this.clientesTableAdapter.Fill(this.lojaecocostaDataSet.Clientes);
        }

        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Frms.frmListarClientes frm = new Frms.frmListarClientes();
            frm.Show();
            this.Close();
        }

        private void listarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frms.frmListarClientes frm = new Frms.frmListarClientes();
            frm.Show();
        }

        private void maskeddata_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
                MessageBox.Show("Data inválida");
        }
    }
}

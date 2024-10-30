using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjetoDesenvolvimento.Classes
{
    /// <summary>
    /// 20190828-ClasseFornecedores: CLASSE PARA A MANIPULAÇÃO DE DADOS DA TABELA FORNECEDORES.
    /// </summary>
    class Fornecedores
    {
        protected const string StringDeConexao = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog = lojaecocosta; Integrated Security = True; Pooling=False";
        /// <summary>
        /// 20190828-MetodoCadastrarFornecedores: METODO PARA INSERIR OS DADOS DO FORNECEDOR NA TABELA.
        /// 20190828-MetodoAtualizarFornecedores: METODO PARA ATUALIZAÇÃO DOS DADOS NA TABELA FORNECEDOR.
        /// 20190828-MetodoDeletarFornecedores: METODO PARA DELETAR OS DADOS NA TABELA FORNECEDOR.
        /// </summary>
        /// <param name="nome">NOME COMPLETO</param>
        /// <param name="cnpj">CNPJ</param>
        /// <param name="data">DATA DE NASCIMENTO</param>
        /// <param name="sexo">GÊNERO</param>
        /// <param name="telefonecelular">TELEFONE CELULAR</param>
        /// <param name="telefoneresidencial">TELEFONE RESIDENCIAL</param>
        /// <param name="email">E-MAIL</param>
        /// <param name="rua">ENDEREÇO</param>
        /// <param name="numerocasa">NUMERO DA CASA</param>
        /// <param name="bairro">BAIRRO</param>
        /// <param name="cep">CEP</param>
        /// <param name="estado">ESTADO</param>
        /// <returns></returns>

        public int CadastrarFornecedores(string nome, string cnpj, string data, string sexo, string telefonecelular, string telefoneresidencial, string email, string rua, string numerocasa, string bairro, string cep, string estado)
        {
            SqlConnection stringDeConexao = new SqlConnection(StringDeConexao);
            try
            {
                string sql = string.Format("INSERT INTO dbo.Fornecedores (nome, cnpj, datanascimento, sexo, telefonecelular, telefoneresidencial, email, rua, numerocasa, bairro, cep, estado) VALUES ('{0}', {1}, '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', {8}, '{9}', {10}, '{11}')", nome, cnpj, data, sexo, telefonecelular, telefoneresidencial, email, rua, numerocasa, bairro, cep, estado);

                SqlCommand comando = new SqlCommand(sql, stringDeConexao);

                stringDeConexao.Open();
                comando.ExecuteNonQuery();

                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro! Fornecedor não cadastrado.\n Por favor entre em contato com o suporte.\n " + ex.Message, "Houve um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return 2;
            }
            finally
            {
                stringDeConexao.Close();
            }
        }

        public int AtualizarFornecedor(string nome, string cnpj, string data, string sexo, string telefonecelular, string telefoneresidencial, string email, string rua, string numerocasa, string bairro, string cep, string estado, string id)
        {
            SqlConnection stringDeConexao = new SqlConnection(StringDeConexao);
            try
            {
                string sql = string.Format("UPDATE dbo.Fornecedores SET nome = '{0}', cnpj = {1}, datanascimento = '{2}', sexo = '{3}', telefonecelular = '{4}', telefoneresidencial = '{5}', email = '{6}', rua = '{7}', numerocasa = {8}, bairro = '{9}', cep = {10}, estado = '{11}' WHERE id_fornecedor = {12}", nome, cnpj, data, sexo, telefonecelular, telefoneresidencial, email, rua, numerocasa, bairro, cep, estado, id);

                SqlCommand comando = new SqlCommand(sql, stringDeConexao);

                stringDeConexao.Open();
                comando.ExecuteNonQuery();
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível atualizar os dados do fornecedor.\n" + ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 2;
            }
            finally
            {
                stringDeConexao.Close();
            }
        }

        public int DeletarFornecedores(string id)
        {
            try
            {
                SqlConnection stringDeConexao = new SqlConnection(StringDeConexao);

                string sql = string.Format("DELETE FROM dbo.Fornecedores WHERE id_fornecedor = {0}", id);

                SqlCommand comando = new SqlCommand(sql, stringDeConexao);

                stringDeConexao.Open();
                comando.ExecuteNonQuery();
                stringDeConexao.Close();
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível deletar os dados do fornecedor.\n" + ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 2;
            }
        }
    }
}

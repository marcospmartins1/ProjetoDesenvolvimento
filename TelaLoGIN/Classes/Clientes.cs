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
    /// 20190827-ClasseClientes: CLASSE PARA A MANIPULAÇÃO DE DADADOS DA TABELA CLIENTES
    /// </summary>
    public class Clientes
    {
        protected const string StringDeConexao = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog = lojaecocosta; Integrated Security = True; Pooling=False";
        /// <summary>
        /// 20190827-MetodoCadastrarCliente: METODO PARA INSERIR OS DADOS DO CLIENTE NA TABELA.
        /// 20190827-MetodoAtualizarCliente: METODO PARA ATUALIZAÇÃO DOS DADOS NA TABELA CLIENTE.
        /// 20190827-MetodoDeletarCliente: METODO PARA DELETAR OS DADOS NA TABELA CLIENTE.
        /// </summary>
        /// <param name="nome">NOME COMPLETO</param>
        /// <param name="cpf">CPF</param>
        /// <param name="rg">RG</param>
        /// <param name="data">DATA DE NASCIMENTO</param>
        /// <param name="sexo">GÊNERO</param>
        /// <param name="telefonecelular">TELEFONE CELULAR</param>
        /// <param name="telefoneresidencial">TELEFONE RESIDENCIAL</param>
        /// <param name="email">EMAIL</param>
        /// <param name="rua">ENDEREÇO</param>
        /// <param name="numerocasa">NUMERO DA CASA</param>
        /// <param name="bairro">BAIRRO</param>
        /// <param name="cep">CEP</param>
        /// <param name="estado">ESTADO</param>
        /// <returns></returns>

        public int CadastrarCliente(string nome, string cpf, string rg, string data, string sexo, string telefonecelular, string telefoneresidencial, string email, string rua, string numerocasa, string bairro, string cep, string estado)
        {
            SqlConnection stringDeConexao = new SqlConnection(StringDeConexao);
            try
            {
                string sql = string.Format("INSERT INTO dbo.Clientes (nome, cpf, rg, datanascimento, sexo, telefonecelular, telefoneresidencial, email, rua, numerocasa, bairro, cep, estado) VALUES ('{0}', {1}, {2}, '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', {9}, '{10}', {11}, '{12}')", nome, cpf, rg, data, sexo, telefonecelular, telefoneresidencial, email, rua, numerocasa, bairro, cep, estado);

                SqlCommand comando = new SqlCommand(sql, stringDeConexao);

                stringDeConexao.Open();
                comando.ExecuteNonQuery();

                return 1;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro! Cliente não cadastrado.\n Por favor entre em contato com o suporte.\n " + ex.Message, "Houve um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return 2;
            }
            finally
            {
                stringDeConexao.Close();
            }
        }

        public int AtualizarCliente(string nome, string cpf, string rg, string data, string sexo, string telefonecelular, string telefoneresidencial, string email, string rua, string numerocasa, string bairro, string cep, string estado, string id)
        {
            SqlConnection stringDeConexao = new SqlConnection(StringDeConexao);
            try
            {
                string sql = string.Format("UPDATE dbo.Clientes SET nome = '{0}', cpf = {1}, rg = {2}, datanascimento = '{3}', sexo = '{4}', telefonecelular = '{5}', telefoneresidencial = '{6}', email = '{7}', rua = '{8}', numerocasa = {9}, bairro = '{10}', cep = {11}, estado = '{12}' WHERE id_cliente = {13}", nome, cpf, rg, data, sexo, telefonecelular, telefoneresidencial, email, rua, numerocasa, bairro, cep, estado, id);

                SqlCommand comando = new SqlCommand(sql, stringDeConexao);

                stringDeConexao.Open();
                comando.ExecuteNonQuery();        
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível atualizar os dados do cliente.\n" + ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 2;
            }
            finally
            {
                stringDeConexao.Close();
            }
        }

        public int DeletarCliente(string id)
        {
            try
            {
                SqlConnection stringDeConexao = new SqlConnection(StringDeConexao);

                string sql = string.Format("DELETE FROM dbo.Clientes WHERE id_cliente = {0}", id);

                SqlCommand comando = new SqlCommand(sql, stringDeConexao);

                stringDeConexao.Open();
                comando.ExecuteNonQuery();
                stringDeConexao.Close();
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível deletar os dados do cliente.\n" + ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 2;
            }
        }
    }
}

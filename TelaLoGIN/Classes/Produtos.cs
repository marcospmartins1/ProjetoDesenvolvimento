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
    /// 20190828-ClasseProdutos: CLASSE PARA A MANIPULAÇÃO DE DADOS DA TABELA PRODUTOS.
    /// </summary>
    class Produtos
    {
        protected const string StringDeConexao = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog = lojaecocosta; Integrated Security = True; Pooling=False";

        /// <summary>
        ///20190828-MetodoCadastrarProdutos: METODO PARA INSERIR OS DADOS DO PRODUTO NA TABELA.
        ///20190828-MetodoAtualizarProdutos: METODO PARA ATUALIZAÇÃO DOS DADOS NA TABELA PRODUTOS.
        ///20190828-MetodoDeletarProdutos: METODO PARA DELETAR OS DADOS NA TABELA PRODUTOS.
        /// </summary>
        /// <param name="nome">NOME DO PRODUTO</param>
        /// <param name="categoria">CATEGORIA DO PRODUTO</param>
        /// <param name="descricao">DESCRIÇÃO DO PRODUTO</param>
        /// <param name="fornecedor">FONECEDOR DO DEVIDO PRODUTO</param>
        /// <param name="quantidade">QUANTIDADE DO PRODUTO</param>
        /// <param name="valor">VALOR UNITÁRIO DO PRODUTO</param>
        /// <param name="valorbruto">VALOR TOTAL DO PRODUTO</param>
        /// <returns></returns>

        public int CadastrarProdutos(string nome, string categoria, string descricao, string fornecedor, string quantidade, string valor, string valorbruto)
        {
            SqlConnection stringDeConexao = new SqlConnection(StringDeConexao);
            try
            {
                string sql = string.Format("INSERT INTO dbo.Produtos (nome, nome_categoria, descricaoproduto, nome_fornecedor, quantidade, valor, valorbruto) VALUES ('{0}', '{1}', '{2}', '{3}', {4}, {5}, {6})", nome, categoria, descricao, fornecedor, quantidade, valor, valorbruto);
                SqlCommand comando = new SqlCommand(sql, stringDeConexao);

                stringDeConexao.Open();
                comando.ExecuteNonQuery();

                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro! Produto não cadastrado.\n Por favor entre em contato com o suporte.\n " + ex.Message, "Houve um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return 2;
            }
            finally
            {
                stringDeConexao.Close();
            }
        }

        public int AtualizarProduto(string nome, string categoria, string descricao, string fornecedor, string quantidade, string valor, string valorbruto, string id)
        {
            SqlConnection stringDeConexao = new SqlConnection(StringDeConexao);
            try
            {
                string sql = string.Format("UPDATE dbo.Produtos SET nome = '{0}', nome_categoria = '{1}', descricaoproduto = '{2}', nome_fornecedor = '{3}', quantidade = {4}, valor = {5}, valorbruto = {6} WHERE id_produto = {7}", nome, categoria, descricao, fornecedor, quantidade, valor, valorbruto, id);

                SqlCommand comando = new SqlCommand(sql, stringDeConexao);

                stringDeConexao.Open();
                comando.ExecuteNonQuery();
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível atualizar os dados do devido produto.\n" + ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 2;
            }
            finally
            {
                stringDeConexao.Close();
            }
        }

        public int DeletarProdutos(string id)
        {
            try
            {
                SqlConnection stringDeConexao = new SqlConnection(StringDeConexao);

                string sql = string.Format("DELETE FROM dbo.Produtos WHERE id_produto = {0}", id);

                SqlCommand comando = new SqlCommand(sql, stringDeConexao);

                stringDeConexao.Open();
                comando.ExecuteNonQuery();
                stringDeConexao.Close();
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível deletar o produto.\n" + ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 2;
            }
        }
    }
}

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
    /// 20190829-ClasseCategoria: CLASSE PARA A MANIPULAÇÃO DE DADOS DA TABELA CATEGORIAS
    /// </summary>
    class Categoria
    {
        protected const string StringDeConexao = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog = lojaecocosta; Integrated Security = True; Pooling=False";
        /// <summary>
        /// 20190829-MetodoCadastrarCategoria: METODO PARA INSERIR OS DADOS DA CATEGORIA NA TABELA.
        /// 20190829-MetodoAtualizarCategoria: METODO PARA ATUALIZAÇÃO DOS DADOS NA TABELA CATEGORIA.
        /// 20190829-MetodoDeletarProdutos: METODO PARA DELETAR OS DADOS NA TABELA CATEGORIA.
        /// </summary>
        /// <param name="nome">NOME CATEGORIA</param>
        /// <returns></returns>
        public int CadastrarCategoria(string nome)
        {
            SqlConnection stringDeConexao = new SqlConnection(StringDeConexao);
            try
            {
                string sql = string.Format("INSERT INTO dbo.Categoria (nome) VALUES ('{0}')", nome);

                SqlCommand comando = new SqlCommand(sql, stringDeConexao);

                stringDeConexao.Open();
                comando.ExecuteNonQuery();

                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro! Categoria não cadastrada.\n Por favor entre em contato com o suporte.\n " + ex.Message, "Houve um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return 2;
            }
            finally
            {
                stringDeConexao.Close();
            }
        }
        public int AtualizarCategoria(string nome, string id)
        {
            SqlConnection stringDeConexao = new SqlConnection(StringDeConexao);
            try
            {
                string sql = string.Format("UPDATE dbo.Categoria SET nome = '{0}' WHERE id_categoria = {1}", nome, id);

                SqlCommand comando = new SqlCommand(sql, stringDeConexao);

                stringDeConexao.Open();
                comando.ExecuteNonQuery();
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível atualizar a Categoria.\n" + ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 2;
            }
            finally
            {
                stringDeConexao.Close();
            }
        }
        public int DeletarCategoria(string id)
        {
            try
            {
                SqlConnection stringDeConexao = new SqlConnection(StringDeConexao);

                string sql = string.Format("DELETE FROM dbo.Categoria WHERE id_categoria = {0}", id);

                SqlCommand comando = new SqlCommand(sql, stringDeConexao);

                stringDeConexao.Open();
                comando.ExecuteNonQuery();
                stringDeConexao.Close();
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível deletar a Categoria.\n" + ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 2;
            }
        }
    }
}

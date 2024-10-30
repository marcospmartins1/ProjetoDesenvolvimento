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
    /// 20190827-ClasseUsuario: CLASSE PARA A AUTENTICAÇÃO DO USUÁRIO.
    /// </summary>
    public class Usuario
    {
        protected const string StringDeConexao = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog = lojaecocosta; Integrated Security = True; Pooling=False";
        /// <summary>
        /// 20190827-MetodoLogin: METODO PARA RELALIZAR A AUTENTICAÇÃO DO USUÁRIO NO SISTEMA.
        /// 20190830-CadastrarUsuario: METODO PARA INSERIR OS DADOS DO USUARIO NA TABELA
        /// 20190830-AtualizarUsuario: METODO PARA ATUALIZAÇÃO DOS DADOS NA TABELA USUARIOS.
        /// 20190830-DeletarUsuario: METODO PARA DELETAR OS DADOS NA TABELA USUARIOS.
        /// </summary>
        /// <param name="usuario">NOME DO USUÁRIO CADASTRADO</param>
        /// <param name="senha">SENHA DO USUÁRIO CADASTRADO</param>
        /// <returns></returns>

        public bool Login(string usuario, string senha)
        {
            try
            {
                SqlConnection conexao = new SqlConnection(StringDeConexao);

                string sql = string.Format("SELECT count (*) FROM Usuarios WHERE login = '{0}' AND senha = '{1}'", usuario, senha);

                SqlCommand comando = new SqlCommand(sql, conexao);

                conexao.Open();
                int resultadoSQL = (int)comando.ExecuteScalar();

                if (resultadoSQL == 1)
                {
                    return true;
                }
                else if (resultadoSQL >= 2)
                {
                    MessageBox.Show("Existe um problema no banco de dados\n CONTATE O SUPORTE", "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado.\n" + ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

        public int CadastrarUsuario(string usuario, string senha, string email)
        {
            SqlConnection stringDeConexao = new SqlConnection(StringDeConexao);
            try
            {
                string sql = string.Format("INSERT INTO dbo.Usuarios (login, senha, email) VALUES ('{0}', '{1}', '{2}')", usuario, senha, email);

                SqlCommand comando = new SqlCommand(sql, stringDeConexao);

                stringDeConexao.Open();
                comando.ExecuteNonQuery();

                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro! Usuário não cadastrado.\n Por favor entre em contato com o suporte.\n " + ex.Message, "Houve um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return 2;
            }
            finally
            {
                stringDeConexao.Close();
            }
        }

        public int AtualizarUsuario(string usuario, string senha, string email, string id)
        {
            SqlConnection stringDeConexao = new SqlConnection(StringDeConexao);
            try
            {
                string sql = string.Format("UPDATE dbo.Usuarios SET login = '{0}', senha = '{1}', email = '{2}' WHERE id = {3}", usuario, senha, email, id);

                SqlCommand comando = new SqlCommand(sql, stringDeConexao);

                stringDeConexao.Open();
                comando.ExecuteNonQuery();
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível atualizar os dados do usuário.\n" + ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 2;
            }
            finally
            {
                stringDeConexao.Close();
            }
        }

        public int DeletarUsuario(string id)
        {
            try
            {
                SqlConnection stringDeConexao = new SqlConnection(StringDeConexao);

                string sql = string.Format("DELETE FROM dbo.Usuarios WHERE id = {0}", id);

                SqlCommand comando = new SqlCommand(sql, stringDeConexao);

                stringDeConexao.Open();
                comando.ExecuteNonQuery();
                stringDeConexao.Close();
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível deletar os dados do usuário.\n" + ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 2;
            }
        }
    }
}

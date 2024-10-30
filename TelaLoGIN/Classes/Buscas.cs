using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjetoDesenvolvimento.Classes
{
    class Buscas
    {
        protected const string StringDeConexao = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog = lojaecocosta; Integrated Security = True; Pooling=False";

        public int PesquisarClientes(string nome)
        {
                SqlConnection stringDeConexao = new SqlConnection(StringDeConexao);
                try
                {
                    string sql = string.Format("SELECT * FROM dbo.Clientes WHERE nome = {0}", nome);

                    SqlCommand comando = new SqlCommand(sql, stringDeConexao);

                    stringDeConexao.Open();
                    comando.ExecuteNonQuery();
                    return 1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro! Não foi possível fazer a listagem dos dados.\n Por favor entre em contato com o suporte.\n " + ex.Message, "Houve um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return 2;
                }
                finally
                {
                    stringDeConexao.Close();
                }
        }
            
    }
}

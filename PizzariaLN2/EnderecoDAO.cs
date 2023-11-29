using PizzariaLN2;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaLN2
{
    internal class EnderecoDAO
    {
        public List<Endereco> SelectEnder()
        {
            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT * FROM Table_2";

            List<Endereco> enders = new List<Endereco>();
            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (dr.Read())
                {
                    Endereco objeto = new Endereco(
                    (int)dr["ID"],
                    (string)dr["PAIS"],
                    (string)dr["ESTADO"],
                    (string)dr["CIDADE"],
                    (string)dr["RUA"],
                    (int)dr["NUMERO"]
                    );

                    enders.Add(objeto);
                }
                dr.Close();
                return enders;//Retornar a lista.
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                conn.CloseConnection();
            }
            return null;
        }


        public void InsertEnder(Endereco ender)
        {
            //esse Connection verde água é o nome da sua classe.
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"INSERT INTO Table_2 VALUES (@pais, @estado, @cidade, @rua, @num)";

            sqlCommand.Parameters.AddWithValue("@pais", ender.Pais);
            sqlCommand.Parameters.AddWithValue("@estado", ender.Estado);
            sqlCommand.Parameters.AddWithValue("@cidade", ender.Cidade);
            sqlCommand.Parameters.AddWithValue("@rua", ender.Rua);
            sqlCommand.Parameters.AddWithValue("@num", ender.Num);

            sqlCommand.ExecuteNonQuery();
        }

        public void UpdateEnder(Endereco ender)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"UPDATE Table_2 SET 
            PAIS       = @pais,
            ESTADO        = @estado, 
            CIDADE   = @cidade,
            RUA       = @rua,
            NUMERO  = @num
            WHERE ID   = @id";

            //idêntico ao do botão insert
            sqlCommand.Parameters.AddWithValue("@pais", ender.Pais);
            sqlCommand.Parameters.AddWithValue("@estado", ender.Estado);
            sqlCommand.Parameters.AddWithValue("@cidade", ender.Cidade);
            sqlCommand.Parameters.AddWithValue("@rua", ender.Rua);
            sqlCommand.Parameters.AddWithValue("@num", ender.Num);
            sqlCommand.Parameters.AddWithValue("@id", ender.Id);

            sqlCommand.ExecuteNonQuery();
        }

        public void DeleteEnder(int id)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"DELETE FROM Table_2 WHERE Id = @id";
            sqlCommand.Parameters.AddWithValue("@id", id);
            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao excluir usuário no banco.\n" + err.Message);
            }
            finally
            {
                connection.CloseConnection();
            }
        }
    }
}


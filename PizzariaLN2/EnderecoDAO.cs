using AssociacaoDesportivaLatina;
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
        public List<Endereco> SelectEndereco()
        {
            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT * FROM Table_2";

            List<Endereco> enderecos = new List<Endereco>();
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

                    enderecos.Add(objeto);
                }
                dr.Close();
                return enderecos;//Retornar a lista.
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
    }
}

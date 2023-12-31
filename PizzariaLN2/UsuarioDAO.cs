﻿using PizzariaLN2;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PizzariaLN2
{
    //DAO = Data Access Objct.
    //Essa é a classe que vai [ligar] com o BD.
    internal class UsuarioDAO
    {
        //(1)
        //void é quando não tem que retornar nada.

        public Usuario Login(Usuario user)
        {
            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT * FROM Table_1 where CPF = @USUARIO and SENHA = @SENHA";

            sqlCom.Parameters.AddWithValue("@USUARIO", user.Cpf);
            sqlCom.Parameters.AddWithValue("@SENHA", user.Pass);
           
            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();
                if (dr.HasRows)
                {
                    Usuario usuarioLogado = null;
                    while (dr.Read())
                    {
                         usuarioLogado = new Usuario(
                    (int)dr["ID"],
                    (string)dr["NOME"],
                    (decimal)dr["TELEFONE"],
                    (decimal)dr["CPF"],
                    (string)dr["SENHA"],
                    (string)dr["EMAIL"]
                    );
                    }
                    dr.Close();
                    return usuarioLogado;
                }
                   
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

        public List<Usuario> SelectUser()
        {
            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT * FROM Table_1";

            List<Usuario> users = new List<Usuario>();
            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (dr.Read())
                {
                    Usuario objeto = new Usuario(
                    (int)dr["ID"],
                    (string)dr["NOME"],
                    (decimal)dr["TELEFONE"],
                    (decimal)dr["CPF"],
                    (string)dr["SENHA"],
                    (string)dr["EMAIL"]
                    );

                    users.Add(objeto);
                }
                dr.Close();
                return users;//Retornar a lista.
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
        public void InsertUser(Usuario user)
        {
            //esse Connection verde água é o nome da sua classe.
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"INSERT INTO Table_1 VALUES (@NOME, @TELEFONE, @CPF, @SENHA, @EMAIL)";

            sqlCommand.Parameters.AddWithValue("@NOME", user.Name);
            sqlCommand.Parameters.AddWithValue("@TELEFONE", user.Phone);
            sqlCommand.Parameters.AddWithValue("@CPF", user.Cpf);
            sqlCommand.Parameters.AddWithValue("@SENHA", Senha.Sha256(user.Pass));
            sqlCommand.Parameters.AddWithValue("@EMAIL", user.Email);

            sqlCommand.ExecuteNonQuery();
        }

        public void UpdateUser(Usuario user)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"UPDATE Table_1 SET 
            NOME       = @nome, 
            CPF        = @cpf, 
            TELEFONE   = @telefone,
            SENHA      = @senha,
            EMAIL      = @email  
            WHERE ID   = @id";

            //idêntico ao do botão insert
            sqlCommand.Parameters.AddWithValue("@nome", user.Name);
            sqlCommand.Parameters.AddWithValue("@telefone", user.Phone);
            sqlCommand.Parameters.AddWithValue("@cpf", user.Cpf);
            sqlCommand.Parameters.AddWithValue("@senha", Senha.Sha256(user.Pass));
            sqlCommand.Parameters.AddWithValue("@email", user.Email);
            sqlCommand.Parameters.AddWithValue("@id", user.Id);

            sqlCommand.ExecuteNonQuery();
        }
        //(1)
        public void DeleteUser(int id)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"DELETE FROM Table_1 WHERE Id = @id";
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

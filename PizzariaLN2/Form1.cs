using AssociacaoDesportivaLatina;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PizzariaLN2
{
    public partial class Form1 : Form
    {
        private int id;
        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateListView()
        {
            listView1.Items.Clear();

            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT * FROM Table_1";

            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (dr.Read())
                {
                    int id = (int)dr["ID"];
                    string name = (string)dr["NOME"];
                    decimal tel = (decimal)dr["TELEFONE"];
                    decimal cpf = (decimal)dr["CPF"];

                    ListViewItem lv = new ListViewItem(id.ToString());
                    lv.SubItems.Add(name);
                    lv.SubItems.Add(tel.ToString());
                    lv.SubItems.Add(cpf.ToString());
                    listView1.Items.Add(lv);

                }
                dr.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                conn.CloseConnection();
            }
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            //esse Connection verde água é o nome da sua classe.
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"INSERT INTO Table_1 VALUES (@nome, @telefone, @cpf)";

            sqlCommand.Parameters.AddWithValue("@nome", txbName.Text);
            sqlCommand.Parameters.AddWithValue("@telefone", txbPhone.Text);
            sqlCommand.Parameters.AddWithValue("@cpf", txbCPF.Text);

            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Cadastrado com sucesso",
                "AVISO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            txbName.Clear();
            txbPhone.Clear();
            txbCPF.Clear();

            UpdateListView();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateListView();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index;
            index = listView1.FocusedItem.Index;
            id = int.Parse(listView1.Items[index].SubItems[0].Text);
            txbName.Text = listView1.Items[index].SubItems[1].Text;
            txbPhone.Text = listView1.Items[index].SubItems[2].Text;
            txbCPF.Text = listView1.Items[index].SubItems[3].Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"UPDATE Table_1 SET 
            NOME       = @nome, 
            CPF        = @cpf, 
            TELEFONE   = @telefone  
            WHERE ID   = @id";

            //idêntico ao do botão insert
            sqlCommand.Parameters.AddWithValue("@nome", txbName.Text);
            sqlCommand.Parameters.AddWithValue("@telefone", txbPhone.Text);
            sqlCommand.Parameters.AddWithValue("@cpf", txbCPF.Text);
            sqlCommand.Parameters.AddWithValue("@id", id);

            sqlCommand.ExecuteNonQuery();

            MessageBox.Show("Atualizado com sucesso",
                "AVISO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            txbName.Clear();
            txbPhone.Clear();
            txbCPF.Clear();

            UpdateListView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Chamando método de exclussão
            //UsuarioDAO nomeDoObj = new UsuarioDAO();
            UsuarioDAO dadosUser = new UsuarioDAO();
            dadosUser.DeleteUser(id);

            MessageBox.Show("Excluido com sucesso",
            "AVISO",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);

            //Limpando campos
            txbName.Clear();
            txbPhone.Clear();
            txbCPF.Clear();

            //Atualizando listView
            UpdateListView();
        }
    }
}

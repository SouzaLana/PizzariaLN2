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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            //esse Connection verde água é o nome da sua classe.
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"INSERT INTO Usuario VALUES (@nome, @telefone, @cpf)";

            sqlCommand.Parameters.AddWithValue("@nome", txbName.Text);
            sqlCommand.Parameters.AddWithValue("@telefone", txbPhone.Text);
            sqlCommand.Parameters.AddWithValue("@cpf", txbCPF.Text);

            sqlCommand.ExecuteNonQuery();

        }

            //private void btnMessage_Click(object sender, EventArgs e)
            //{
            //    if (validarForm())
            //        Salvar();

            //    string name = txbName.Text;
            //    string phone = txbPhone.Text;
            //    string cpf = txbCPF.Text;

            //    string message = "Nome: " + name +
            //                     "\nTelefone: " + phone +
            //                     "\nCPF: " + cpf;

            //    MessageBox.Show(message, "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}

            //private void Salvar()
            //{
            //    MessageBox.Show("Os dados foram salvos!");
            //}

            //private bool validarForm()
            //{
            //    if (txbName.Text == "")
            //    {
            //        MessageBox.Show("Informe o nome");
            //        txbName.Focus();
            //        return false;
            //    }
            //    else if(txbPhone.Text == "")
            //    {
            //        MessageBox.Show("Informe o telefone");
            //        txbPhone.Focus();
            //        return false;
            //    }
            //    else if (txbCPF.Text == "")
            //    {
            //        MessageBox.Show("Informe o CPF");
            //        txbCPF.Focus();
            //        return false;
            //    }
            //    return true;
            //}
        }
}

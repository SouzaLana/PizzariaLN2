using PizzariaLN2;
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
using System.Security.Cryptography;
using System.Net;
using System.Net.Mail;
using System.Linq.Expressions;

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
            UsuarioDAO dadosUser = new UsuarioDAO();
            List<Usuario> users = dadosUser.SelectUser();

            try
            {
                foreach (Usuario user in users)
                {

                    ListViewItem lv = new ListViewItem(user.Id.ToString());
                    lv.SubItems.Add(user.Name);
                    lv.SubItems.Add(user.Phone.ToString());
                    lv.SubItems.Add(user.Cpf.ToString());
                    lv.SubItems.Add(user.Pass);
                    lv.SubItems.Add(user.Email);
                    listView1.Items.Add(lv);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            //(4) -  (ver classe usuário).
            try
            {
                //Criar objeto da classe Usuario.
                //esse verde água é o nome da sua classe.
                Usuario user = new Usuario(
                    txbName.Text,
                    Convert.ToDecimal(txbPhone.Text),
                    Convert.ToDecimal(txbCPF.Text),
                    txbPASS.Text,
                    txbEmail.Text
                    );

                //Chamando método de inserir (inserção).
                //UsuarioDAO nomeDoObj = new UsuarioDAO();
                UsuarioDAO dadosUser = new UsuarioDAO();
                dadosUser.InsertUser(user);

                MessageBox.Show("Cadastrado com sucesso",
                    "AVISO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

            txbName.Clear();
            txbPhone.Clear();
            txbCPF.Clear();
            txbPASS.Clear();
            txbEmail.Clear();

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
            txbPASS.Text = listView1.Items[index].SubItems[4].Text;
            txbEmail.Text = listView1.Items[index].SubItems[5].Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //(4) -  (ver classe usuário).
            try
            {
                //Criar objeto da classe Usuario.
                //esse verde água é o nome da sua classe.
                Usuario user = new Usuario(
                    id,
                    txbName.Text,
                    Convert.ToDecimal(txbPhone.Text),
                    Convert.ToDecimal(txbCPF.Text),
                    txbPASS.Text,
                    txbEmail.Text
                    );

                //Chamando método de inserir (inserção).
                //UsuarioDAO nomeDoObj = new UsuarioDAO();
                UsuarioDAO dadosUser = new UsuarioDAO();
                dadosUser.UpdateUser(user);

                MessageBox.Show("Atualizado com sucesso",
                    "AVISO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

            txbName.Clear();
            txbPhone.Clear();
            txbCPF.Clear();
            txbPASS.Clear();
            txbEmail.Clear();

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
            txbPASS.Clear();
            txbEmail.Clear();

            //Atualizando listView
            UpdateListView();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login TelaLogin = new Login();
            TelaLogin.ShowDialog();
        }

        private void txbPASS_TextChanged(object sender, EventArgs e)
        {
            txbPASS.Text = new string('*', txbPASS.Text.Length);
        }
    }
}

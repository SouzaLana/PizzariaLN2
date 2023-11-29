using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PizzariaLN2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string hashPass = Senha.Sha256(txbPASS1.Text);
            Usuario user = new Usuario(
                Convert.ToDecimal(txbName1.Text),
                hashPass
                );
           

            //inserir dado
            UsuarioDAO dadosUser = new UsuarioDAO();
            if (dadosUser.Login(user))
            {
                // instânciando um objeto da classe form1 (esses são os comando para abrir outra tela)
                Form2 tela = new Form2();
                tela.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuário inválido");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 tela = new Form1();
            tela.ShowDialog();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txbName1.Clear();
            txbPASS1.Clear();
        }

        private void txbPASS1_TextChanged(object sender, EventArgs e)
        {
            txbPASS1.Text = new string('*', txbPASS1.Text.Length);
        }
    }
}

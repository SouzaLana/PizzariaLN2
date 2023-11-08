using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            Usuario user = new Usuario(
                txbName1.Text
                );
            Usuario pass = new Usuario(
                Convert.ToDecimal(txbCPF1.Text)
                );

            //inserir dado
            UsuarioDAO dadosUser = new UsuarioDAO();
            if (dadosUser.Login(user, pass))
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
            txbCPF1.Clear();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            UsuarioDAO dadosUser = new UsuarioDAO();
            if (dadosUser.Login("1234","12345"))
            {
                Form1 form1 = new Form1();
                form1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuário inválido");
            }
        }
    }
}

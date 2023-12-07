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
    public partial class Form2 : Form
    {
        Usuario usuarioLogado;
        public Form2(Usuario usuario)
        {
            InitializeComponent();
            this.usuarioLogado = usuario;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cardapio tela2 = new Cardapio();
            tela2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dados tela = new Dados(usuarioLogado);
            tela.ShowDialog();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            Compra compra = new Compra();
            compra.ShowDialog();
        }
    }
}

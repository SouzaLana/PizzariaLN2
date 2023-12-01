using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PizzariaLN2
{
    public partial class Compra : Form
    {
        private MonthCalendar monthCalendar;
        public Compra()
        {
            InitializeComponent();
        }

        private void Compra_Load(object sender, EventArgs e)
        {
            monthCalendar = new MonthCalendar();
            monthCalendar.Location = new System.Drawing.Point(359, 169);
            monthCalendar.DateChanged += monthCalendar1_DateChanged;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            MonthCalendar monthCalendar = (MonthCalendar)sender;
            DateTime selectDate = e.Start;
            MessageBox.Show($"Data selecionada: {selectDate.ToShortDateString()}\nAgora você pode processar a compra para essa data");
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            
            DateTime selectDate = monthCalendar.SelectionStart;

            List<string> pedidos = GetPedidos();

            if(pedidos.Count > 0)
            {
                string itens = string.Join(", ", pedidos);
                MessageBox.Show($"Compra efetuada!\nItens: {itens}\nData: { selectDate.ToShortDateString()}");
            }
            else
            {
                MessageBox.Show("Por favor, selecione pelo menos um sabor para comprar");
            }

        }

        private List<string> GetPedidos()
        {
            List<string> pedidos = new List<string>();

            foreach (Control control in this.Controls)
            {
                if(control is CheckBox checkBox && checkBox.Checked)
                {
                    pedidos.Add(checkBox.Text);
                }
            }
            return pedidos;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

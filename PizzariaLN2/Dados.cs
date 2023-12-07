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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net;
using System.Net.Mail;
using System.Linq.Expressions;
using System.Data.SqlClient;

namespace PizzariaLN2
{
    public partial class Dados : Form
    {
        private int id;
        Endereco ender;
        Usuario usuarioLogado;
        public Dados(Usuario usuario)
        {
            InitializeComponent();
            usuarioLogado = usuario;
        }
        private void UpdateListView()
        {
            listView2.Items.Clear();
            EnderecoDAO dadosEndereco = new EnderecoDAO();
            List<Endereco> enders = dadosEndereco.SelectEnder();

            try
            {
                foreach (Endereco ender in enders)
                {
                    ListViewItem lv2 = new ListViewItem(ender.Id.ToString());
                    lv2.SubItems.Add(ender.Pais);
                    lv2.SubItems.Add(ender.Estado);
                    lv2.SubItems.Add(ender.Cidade);
                    lv2.SubItems.Add(ender.Rua);
                    lv2.SubItems.Add(ender.Num.ToString());
                    listView2.Items.Add(lv2);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //esse verde água é o nome da sua classe.
                ender = new Endereco(
                    txbPais.Text,
                    txbEstado.Text,
                    txbCidade.Text,
                    txbRua.Text,
                    Convert.ToInt16(txbNum.Text)
                    );

                //Chamando método de inserir (inserção).
                EnderecoDAO dadosEndereco = new EnderecoDAO();
                dadosEndereco.InsertEnder(ender);

                if (rbtnEmail.Checked)
                    EnviarEmail();

                MessageBox.Show("Cadastrado com sucesso",
                    "AVISO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

            txbPais.Clear();
            txbEstado.Clear();
            txbCidade.Clear();
            txbRua.Clear();
            txbNum.Clear();

            UpdateListView();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                //esse verde água é o nome da sua classe.
                Endereco ender = new Endereco(
                    id,
                    txbPais.Text,
                    txbEstado.Text,
                    txbCidade.Text,
                    txbRua.Text,
                    Convert.ToInt16(txbNum.Text)
                    );

                //Chamando método de inserir (inserção).
                //UsuarioDAO nomeDoObj = new UsuarioDAO();
                EnderecoDAO dadosEndereco = new EnderecoDAO();
                dadosEndereco.UpdateEnder(ender);

                MessageBox.Show("Atualizado com sucesso",
                    "AVISO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

            txbPais.Clear();
            txbEstado.Clear();
            txbCidade.Clear();
            txbRua.Clear();
            txbNum.Clear();

            UpdateListView();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //Chamando método de exclussão
            EnderecoDAO dadosEndereco = new EnderecoDAO();
            dadosEndereco.DeleteEnder(id);

            MessageBox.Show("Excluido com sucesso",
            "AVISO",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);

            //Limpando campos
            txbPais.Clear();
            txbEstado.Clear();
            txbCidade.Clear();
            txbRua.Clear();
            txbNum.Clear();

            //Atualizando listView
            UpdateListView();
        }

        private void listView2_DoubleClick(object sender, EventArgs e)
        {
            int index;
            index = listView2.FocusedItem.Index;
            id = int.Parse(listView2.Items[index].SubItems[0].Text);
            txbPais.Text = listView2.Items[index].SubItems[1].Text;
            txbEstado.Text = listView2.Items[index].SubItems[2].Text;
            txbCidade.Text = listView2.Items[index].SubItems[3].Text;
            txbRua.Text = listView2.Items[index].SubItems[4].Text;
            txbNum.Text = (listView2.Items[index].SubItems[5].Text);
        }

        private void Dados_Load_1(object sender, EventArgs e)
        {
            UpdateListView();
        }

        private void EnviarEmail()
        {
            try
            {
                string destinatario = usuarioLogado.Email;
                string assunto = "Novo endereço cadastrado";
                string CorpoEmail = corpoEmail();

                EnviarEmail(destinatario, assunto, CorpoEmail);

                MessageBox.Show("E-mail enviado com sucesso!",
                    "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao enviar e-mail!",
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void rbtnEmail_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private List<Usuario> DadosUser()
        {
            UsuarioDAO dadosUser = new UsuarioDAO();
            return dadosUser.SelectUser();
        }

        private List<Endereco> DadosEndereco()
        {
            EnderecoDAO dadosEndereco = new EnderecoDAO();
            return dadosEndereco.SelectEnder();
        }

        private string corpoEmail()
        {
            StringBuilder CorpoEmail = new StringBuilder();
            CorpoEmail.AppendLine("assunto");

                CorpoEmail.AppendLine($"País: {ender.Pais}, Estado: {ender.Estado}, Cidade: {ender.Cidade}, Rua: {ender.Rua}, Número: {ender.Num}");
            

                CorpoEmail.AppendLine($"Nome: {usuarioLogado.Name}, Telefone: {usuarioLogado.Phone}, CPF: {usuarioLogado.Cpf}");
            

            return CorpoEmail.ToString();
        }

        private void EnviarEmail (string destinatario, string assunto, string CorpoEmail)
        {
            MailMessage mail = new MailMessage
            {
                From = new MailAddress("trabalhopr2023@gmail.com")
            };
            SmtpClient smtp = new SmtpClient
            {
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("trabalhopr2023@gmail.com", "TrabalhoPR-2"),
                Host = "smtp.gmail.com"
            };

            //recipient
            mail.To.Add(new MailAddress("trabalhopr2023@gmail.com"));

            //mail.IsBodyHtml = true;

            mail.Body = CorpoEmail;
            smtp.Send(mail);

            //string servidor = "smtp.gmail.com";
            //int porta = 587;
            //string usuarioS = "trabalhopr2023@gmail.com";
            //string senhaS = "TrabalhoPR-2";

            //SmtpClient clientSmtp = new SmtpClient(servidor)
            //{
            //    Port = porta,
            //    Credentials = new NetworkCredential(usuarioS, senhaS),
            //    EnableSsl = true
            //};

            //MailMessage message = new MailMessage(usuarioS, destinatario)
            //{
            //    Subject = assunto,
            //    Body = CorpoEmail
            //};

            //clientSmtp.Send(message);
        }
    }
    
}

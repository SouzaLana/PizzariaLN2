namespace PizzariaLN2
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ColumnHeader columnHeader4;
            this.btnMessage = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CPF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.senha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txbPhone = new System.Windows.Forms.MaskedTextBox();
            this.txbCPF = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txbPASS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnMessage
            // 
            this.btnMessage.BackColor = System.Drawing.Color.IndianRed;
            this.btnMessage.ForeColor = System.Drawing.Color.Black;
            this.btnMessage.Location = new System.Drawing.Point(214, 58);
            this.btnMessage.Name = "btnMessage";
            this.btnMessage.Size = new System.Drawing.Size(177, 52);
            this.btnMessage.TabIndex = 0;
            this.btnMessage.Text = "Salvar";
            this.btnMessage.UseVisualStyleBackColor = false;
            this.btnMessage.Click += new System.EventHandler(this.btnMessage_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.RosyBrown;
            this.lblName.Location = new System.Drawing.Point(52, 34);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nome";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.BackColor = System.Drawing.Color.RosyBrown;
            this.lblPhone.Location = new System.Drawing.Point(52, 83);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(49, 13);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "Telefone";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.BackColor = System.Drawing.Color.RosyBrown;
            this.lblCPF.Location = new System.Drawing.Point(52, 132);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(27, 13);
            this.lblCPF.TabIndex = 3;
            this.lblCPF.Text = "CPF";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(55, 50);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(100, 20);
            this.txbName.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.CPF,
            this.senha,
            columnHeader4});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 270);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(424, 97);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 37;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome";
            this.columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Telefone";
            this.columnHeader3.Width = 79;
            // 
            // CPF
            // 
            this.CPF.Text = "CPF";
            // 
            // senha
            // 
            this.senha.Text = "Senha";
            // 
            // txbPhone
            // 
            this.txbPhone.Location = new System.Drawing.Point(55, 99);
            this.txbPhone.Mask = "(999) 00000-0000";
            this.txbPhone.Name = "txbPhone";
            this.txbPhone.Size = new System.Drawing.Size(100, 20);
            this.txbPhone.TabIndex = 2;
            this.txbPhone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txbCPF
            // 
            this.txbCPF.Location = new System.Drawing.Point(55, 148);
            this.txbCPF.Mask = "000.000.000-00";
            this.txbCPF.Name = "txbCPF";
            this.txbCPF.Size = new System.Drawing.Size(100, 20);
            this.txbCPF.TabIndex = 3;
            this.txbCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(214, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 52);
            this.button1.TabIndex = 10;
            this.button1.Text = "Editar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.IndianRed;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(214, 172);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 57);
            this.button2.TabIndex = 11;
            this.button2.Text = "Excluir";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txbPASS
            // 
            this.txbPASS.Location = new System.Drawing.Point(55, 192);
            this.txbPASS.Name = "txbPASS";
            this.txbPASS.Size = new System.Drawing.Size(100, 20);
            this.txbPASS.TabIndex = 13;
            this.txbPASS.TextChanged += new System.EventHandler(this.txbPASS_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RosyBrown;
            this.label1.Location = new System.Drawing.Point(52, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Senha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.RosyBrown;
            this.label2.Location = new System.Drawing.Point(52, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "E-mail";
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(55, 234);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(100, 20);
            this.txbEmail.TabIndex = 16;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Email";
            columnHeader4.Width = 112;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(448, 398);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbPASS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbCPF);
            this.Controls.Add(this.txbPhone);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnMessage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMessage;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.MaskedTextBox txbPhone;
        private System.Windows.Forms.MaskedTextBox txbCPF;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColumnHeader CPF;
        private System.Windows.Forms.TextBox txbPASS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader senha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbEmail;
    }
}


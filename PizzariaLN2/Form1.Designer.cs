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
            this.btnMessage = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txbPhone = new System.Windows.Forms.MaskedTextBox();
            this.txbCPF = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnMessage
            // 
            this.btnMessage.BackColor = System.Drawing.Color.IndianRed;
            this.btnMessage.ForeColor = System.Drawing.Color.Black;
            this.btnMessage.Location = new System.Drawing.Point(217, 124);
            this.btnMessage.Name = "btnMessage";
            this.btnMessage.Size = new System.Drawing.Size(177, 73);
            this.btnMessage.TabIndex = 0;
            this.btnMessage.Text = "Salvar";
            this.btnMessage.UseVisualStyleBackColor = false;
            this.btnMessage.Click += new System.EventHandler(this.btnMessage_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.RosyBrown;
            this.lblName.Location = new System.Drawing.Point(54, 86);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nome";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.BackColor = System.Drawing.Color.RosyBrown;
            this.lblPhone.Location = new System.Drawing.Point(54, 135);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(49, 13);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "Telefone";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.BackColor = System.Drawing.Color.RosyBrown;
            this.lblCPF.Location = new System.Drawing.Point(54, 184);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(27, 13);
            this.lblCPF.TabIndex = 3;
            this.lblCPF.Text = "CPF";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(57, 102);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(100, 20);
            this.txbName.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(111, 268);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(182, 97);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nome";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Telefone";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "CPF";
            // 
            // txbPhone
            // 
            this.txbPhone.Location = new System.Drawing.Point(57, 151);
            this.txbPhone.Mask = "(999) 00000-0000";
            this.txbPhone.Name = "txbPhone";
            this.txbPhone.Size = new System.Drawing.Size(100, 20);
            this.txbPhone.TabIndex = 2;
            this.txbPhone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txbCPF
            // 
            this.txbCPF.Location = new System.Drawing.Point(57, 200);
            this.txbCPF.Mask = "000.000.000-00";
            this.txbCPF.Name = "txbCPF";
            this.txbCPF.Size = new System.Drawing.Size(100, 20);
            this.txbCPF.TabIndex = 3;
            this.txbCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(448, 398);
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
    }
}


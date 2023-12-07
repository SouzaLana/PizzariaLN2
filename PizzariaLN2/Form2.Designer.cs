namespace PizzariaLN2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lblPizza = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCompra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPizza
            // 
            this.lblPizza.AutoSize = true;
            this.lblPizza.BackColor = System.Drawing.Color.Peru;
            this.lblPizza.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPizza.Font = new System.Drawing.Font("Monospac821 BT", 50.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPizza.Location = new System.Drawing.Point(105, 37);
            this.lblPizza.Name = "lblPizza";
            this.lblPizza.Size = new System.Drawing.Size(357, 83);
            this.lblPizza.TabIndex = 0;
            this.lblPizza.Text = "PizzasLN";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SandyBrown;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(160, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 78);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cardápio";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SandyBrown;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.button2.Location = new System.Drawing.Point(160, 240);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(260, 78);
            this.button2.TabIndex = 3;
            this.button2.Text = "Seus Dados";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCompra
            // 
            this.btnCompra.BackColor = System.Drawing.Color.SandyBrown;
            this.btnCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnCompra.Location = new System.Drawing.Point(160, 335);
            this.btnCompra.Name = "btnCompra";
            this.btnCompra.Size = new System.Drawing.Size(260, 78);
            this.btnCompra.TabIndex = 5;
            this.btnCompra.Text = "Comprar";
            this.btnCompra.UseVisualStyleBackColor = false;
            this.btnCompra.Click += new System.EventHandler(this.btnCompra_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(574, 628);
            this.Controls.Add(this.btnCompra);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblPizza);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPizza;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCompra;
    }
}
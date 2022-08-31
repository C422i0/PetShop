namespace PetShop
{
    partial class Form5
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnCad = new System.Windows.Forms.Button();
            this.btnBackHub = new System.Windows.Forms.Button();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdEndereco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNumeroCasa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPesc = new System.Windows.Forms.Button();
            this.btnAlt = new System.Windows.Forms.Button();
            this.btnDelet = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MintCream;
            this.panel1.Controls.Add(this.btnDelet);
            this.panel1.Controls.Add(this.btnAlt);
            this.panel1.Controls.Add(this.btnPesc);
            this.panel1.Controls.Add(this.BtnCad);
            this.panel1.Controls.Add(this.btnBackHub);
            this.panel1.Controls.Add(this.txtIdCliente);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtIdEndereco);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtNomeCliente);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtNumeroCasa);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(41, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 379);
            this.panel1.TabIndex = 0;
            // 
            // BtnCad
            // 
            this.BtnCad.Location = new System.Drawing.Point(249, 353);
            this.BtnCad.Name = "BtnCad";
            this.BtnCad.Size = new System.Drawing.Size(103, 23);
            this.BtnCad.TabIndex = 8;
            this.BtnCad.Text = "Cadastrar Cliente";
            this.BtnCad.UseVisualStyleBackColor = true;
            this.BtnCad.Click += new System.EventHandler(this.BtnCad_Click);
            // 
            // btnBackHub
            // 
            this.btnBackHub.Location = new System.Drawing.Point(358, 353);
            this.btnBackHub.Name = "btnBackHub";
            this.btnBackHub.Size = new System.Drawing.Size(80, 23);
            this.btnBackHub.TabIndex = 8;
            this.btnBackHub.Text = "Voltar ao Hub";
            this.btnBackHub.UseVisualStyleBackColor = true;
            this.btnBackHub.Click += new System.EventHandler(this.btnBackHub_Click);
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(292, 161);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(100, 20);
            this.txtIdCliente.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(289, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "id Cliente";
            // 
            // txtIdEndereco
            // 
            this.txtIdEndereco.Location = new System.Drawing.Point(31, 212);
            this.txtIdEndereco.Name = "txtIdEndereco";
            this.txtIdEndereco.Size = new System.Drawing.Size(151, 20);
            this.txtIdEndereco.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Id endereço";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(31, 48);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(361, 20);
            this.txtNomeCliente.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(31, 106);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(361, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // txtNumeroCasa
            // 
            this.txtNumeroCasa.Location = new System.Drawing.Point(31, 161);
            this.txtNumeroCasa.Name = "txtNumeroCasa";
            this.txtNumeroCasa.Size = new System.Drawing.Size(151, 20);
            this.txtNumeroCasa.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero da casa ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "E- mail";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // btnPesc
            // 
            this.btnPesc.Location = new System.Drawing.Point(168, 353);
            this.btnPesc.Name = "btnPesc";
            this.btnPesc.Size = new System.Drawing.Size(75, 23);
            this.btnPesc.TabIndex = 9;
            this.btnPesc.Text = "Pesquisar";
            this.btnPesc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPesc.UseVisualStyleBackColor = true;
            this.btnPesc.Click += new System.EventHandler(this.btnPesc_Click);
            // 
            // btnAlt
            // 
            this.btnAlt.Location = new System.Drawing.Point(101, 353);
            this.btnAlt.Name = "btnAlt";
            this.btnAlt.Size = new System.Drawing.Size(61, 23);
            this.btnAlt.TabIndex = 10;
            this.btnAlt.Text = "Alterar";
            this.btnAlt.UseVisualStyleBackColor = true;
            this.btnAlt.Click += new System.EventHandler(this.btnAlt_Click);
            // 
            // btnDelet
            // 
            this.btnDelet.Location = new System.Drawing.Point(20, 353);
            this.btnDelet.Name = "btnDelet";
            this.btnDelet.Size = new System.Drawing.Size(75, 23);
            this.btnDelet.TabIndex = 11;
            this.btnDelet.Text = "Deletar";
            this.btnDelet.UseVisualStyleBackColor = true;
            this.btnDelet.Click += new System.EventHandler(this.btnDelet_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(533, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form5";
            this.Text = "Cadastro de clientes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNumeroCasa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCad;
        private System.Windows.Forms.Button btnBackHub;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdEndereco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDelet;
        private System.Windows.Forms.Button btnAlt;
        private System.Windows.Forms.Button btnPesc;
    }
}
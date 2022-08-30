namespace PetShop
{
    partial class Form3
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
            this.btnDelet = new System.Windows.Forms.Button();
            this.btnAlt = new System.Windows.Forms.Button();
            this.btnPesc = new System.Windows.Forms.Button();
            this.btnVolta = new System.Windows.Forms.Button();
            this.btnCadHub = new System.Windows.Forms.Button();
            this.btnCadastoIni = new System.Windows.Forms.Button();
            this.txtCadSenha = new System.Windows.Forms.TextBox();
            this.txtCadNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MintCream;
            this.panel1.Controls.Add(this.btnDelet);
            this.panel1.Controls.Add(this.btnAlt);
            this.panel1.Controls.Add(this.btnPesc);
            this.panel1.Controls.Add(this.btnVolta);
            this.panel1.Controls.Add(this.btnCadHub);
            this.panel1.Controls.Add(this.btnCadastoIni);
            this.panel1.Controls.Add(this.txtCadSenha);
            this.panel1.Controls.Add(this.txtCadNome);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(39, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 324);
            this.panel1.TabIndex = 0;
            // 
            // btnDelet
            // 
            this.btnDelet.Location = new System.Drawing.Point(43, 298);
            this.btnDelet.Name = "btnDelet";
            this.btnDelet.Size = new System.Drawing.Size(75, 23);
            this.btnDelet.TabIndex = 9;
            this.btnDelet.Text = "Deletar";
            this.btnDelet.UseVisualStyleBackColor = true;
            this.btnDelet.Click += new System.EventHandler(this.btnDelet_Click);
            // 
            // btnAlt
            // 
            this.btnAlt.Location = new System.Drawing.Point(124, 298);
            this.btnAlt.Name = "btnAlt";
            this.btnAlt.Size = new System.Drawing.Size(75, 23);
            this.btnAlt.TabIndex = 8;
            this.btnAlt.Text = "Alterar";
            this.btnAlt.UseVisualStyleBackColor = true;
            this.btnAlt.Click += new System.EventHandler(this.btnAlt_Click);
            // 
            // btnPesc
            // 
            this.btnPesc.Location = new System.Drawing.Point(205, 298);
            this.btnPesc.Name = "btnPesc";
            this.btnPesc.Size = new System.Drawing.Size(75, 23);
            this.btnPesc.TabIndex = 7;
            this.btnPesc.Text = "Pesquisar";
            this.btnPesc.UseVisualStyleBackColor = true;
            this.btnPesc.Click += new System.EventHandler(this.btnPesc_Click);
            // 
            // btnVolta
            // 
            this.btnVolta.Location = new System.Drawing.Point(286, 298);
            this.btnVolta.Name = "btnVolta";
            this.btnVolta.Size = new System.Drawing.Size(86, 23);
            this.btnVolta.TabIndex = 6;
            this.btnVolta.Text = "Voltar ao Hub";
            this.btnVolta.UseVisualStyleBackColor = true;
            this.btnVolta.Click += new System.EventHandler(this.btnVolta_Click);
            // 
            // btnCadHub
            // 
            this.btnCadHub.Location = new System.Drawing.Point(63, 204);
            this.btnCadHub.Name = "btnCadHub";
            this.btnCadHub.Size = new System.Drawing.Size(267, 21);
            this.btnCadHub.TabIndex = 5;
            this.btnCadHub.Text = "Cadastrar e voltar ao Hub";
            this.btnCadHub.UseVisualStyleBackColor = true;
            this.btnCadHub.Click += new System.EventHandler(this.btnCadHub_Click);
            // 
            // btnCadastoIni
            // 
            this.btnCadastoIni.Location = new System.Drawing.Point(63, 165);
            this.btnCadastoIni.Name = "btnCadastoIni";
            this.btnCadastoIni.Size = new System.Drawing.Size(267, 23);
            this.btnCadastoIni.TabIndex = 4;
            this.btnCadastoIni.Text = "Cadastrar e voltar ao login";
            this.btnCadastoIni.UseVisualStyleBackColor = true;
            this.btnCadastoIni.Click += new System.EventHandler(this.btnCadasto_Click);
            // 
            // txtCadSenha
            // 
            this.txtCadSenha.Location = new System.Drawing.Point(63, 120);
            this.txtCadSenha.Name = "txtCadSenha";
            this.txtCadSenha.Size = new System.Drawing.Size(267, 20);
            this.txtCadSenha.TabIndex = 3;
            // 
            // txtCadNome
            // 
            this.txtCadNome.Location = new System.Drawing.Point(63, 67);
            this.txtCadNome.Name = "txtCadNome";
            this.txtCadNome.Size = new System.Drawing.Size(267, 20);
            this.txtCadNome.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(479, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.Text = "Cadastro de Usuarios";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCadastoIni;
        private System.Windows.Forms.TextBox txtCadSenha;
        private System.Windows.Forms.TextBox txtCadNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadHub;
        private System.Windows.Forms.Button btnVolta;
        private System.Windows.Forms.Button btnDelet;
        private System.Windows.Forms.Button btnAlt;
        private System.Windows.Forms.Button btnPesc;
    }
}
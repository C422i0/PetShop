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
            this.btnCadastoIni = new System.Windows.Forms.Button();
            this.txtCadSenha = new System.Windows.Forms.TextBox();
            this.txtCadNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadHub = new System.Windows.Forms.Button();
            this.btnVolta = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MintCream;
            this.panel1.Controls.Add(this.btnVolta);
            this.panel1.Controls.Add(this.btnCadHub);
            this.panel1.Controls.Add(this.btnCadastoIni);
            this.panel1.Controls.Add(this.txtCadSenha);
            this.panel1.Controls.Add(this.txtCadNome);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(43, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 324);
            this.panel1.TabIndex = 0;
            // 
            // btnCadastoIni
            // 
            this.btnCadastoIni.Location = new System.Drawing.Point(26, 184);
            this.btnCadastoIni.Name = "btnCadastoIni";
            this.btnCadastoIni.Size = new System.Drawing.Size(143, 23);
            this.btnCadastoIni.TabIndex = 4;
            this.btnCadastoIni.Text = "Cadastrar e voltar ao login";
            this.btnCadastoIni.UseVisualStyleBackColor = true;
            this.btnCadastoIni.Click += new System.EventHandler(this.btnCadasto_Click);
            // 
            // txtCadSenha
            // 
            this.txtCadSenha.Location = new System.Drawing.Point(26, 139);
            this.txtCadSenha.Name = "txtCadSenha";
            this.txtCadSenha.Size = new System.Drawing.Size(143, 20);
            this.txtCadSenha.TabIndex = 3;
            // 
            // txtCadNome
            // 
            this.txtCadNome.Location = new System.Drawing.Point(26, 86);
            this.txtCadNome.Name = "txtCadNome";
            this.txtCadNome.Size = new System.Drawing.Size(143, 20);
            this.txtCadNome.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // btnCadHub
            // 
            this.btnCadHub.Location = new System.Drawing.Point(26, 223);
            this.btnCadHub.Name = "btnCadHub";
            this.btnCadHub.Size = new System.Drawing.Size(143, 21);
            this.btnCadHub.TabIndex = 5;
            this.btnCadHub.Text = "Cadastrar e voltar ao Hub";
            this.btnCadHub.UseVisualStyleBackColor = true;
            this.btnCadHub.Click += new System.EventHandler(this.btnCadHub_Click);
            // 
            // btnVolta
            // 
            this.btnVolta.Location = new System.Drawing.Point(119, 301);
            this.btnVolta.Name = "btnVolta";
            this.btnVolta.Size = new System.Drawing.Size(81, 23);
            this.btnVolta.TabIndex = 6;
            this.btnVolta.Text = "Voltar ao Hub";
            this.btnVolta.UseVisualStyleBackColor = true;
            this.btnVolta.Click += new System.EventHandler(this.btnVolta_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(294, 450);
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
    }
}
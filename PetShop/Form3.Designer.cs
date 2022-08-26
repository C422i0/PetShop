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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCadNome = new System.Windows.Forms.TextBox();
            this.txtCadSenha = new System.Windows.Forms.TextBox();
            this.btnCadasto = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MintCream;
            this.panel1.Controls.Add(this.btnCadasto);
            this.panel1.Controls.Add(this.txtCadSenha);
            this.panel1.Controls.Add(this.txtCadNome);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(43, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 324);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha";
            // 
            // txtCadNome
            // 
            this.txtCadNome.Location = new System.Drawing.Point(44, 86);
            this.txtCadNome.Name = "txtCadNome";
            this.txtCadNome.Size = new System.Drawing.Size(100, 20);
            this.txtCadNome.TabIndex = 2;
            // 
            // txtCadSenha
            // 
            this.txtCadSenha.Location = new System.Drawing.Point(44, 139);
            this.txtCadSenha.Name = "txtCadSenha";
            this.txtCadSenha.Size = new System.Drawing.Size(100, 20);
            this.txtCadSenha.TabIndex = 3;
            // 
            // btnCadasto
            // 
            this.btnCadasto.Location = new System.Drawing.Point(44, 183);
            this.btnCadasto.Name = "btnCadasto";
            this.btnCadasto.Size = new System.Drawing.Size(100, 23);
            this.btnCadasto.TabIndex = 4;
            this.btnCadasto.Text = "Cadastrar";
            this.btnCadasto.UseVisualStyleBackColor = true;
            this.btnCadasto.Click += new System.EventHandler(this.btnCadasto_Click);
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
        private System.Windows.Forms.Button btnCadasto;
        private System.Windows.Forms.TextBox txtCadSenha;
        private System.Windows.Forms.TextBox txtCadNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
namespace PetShop
{
    partial class Form11
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
            this.btnCad = new System.Windows.Forms.Button();
            this.btnHub = new System.Windows.Forms.Button();
            this.btnPesc = new System.Windows.Forms.Button();
            this.btnAlt = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdServ = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MintCream;
            this.panel1.Controls.Add(this.txtValor);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.txtIdServ);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnDel);
            this.panel1.Controls.Add(this.btnAlt);
            this.panel1.Controls.Add(this.btnPesc);
            this.panel1.Controls.Add(this.btnHub);
            this.panel1.Controls.Add(this.btnCad);
            this.panel1.Location = new System.Drawing.Point(29, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 243);
            this.panel1.TabIndex = 0;
            // 
            // btnCad
            // 
            this.btnCad.Location = new System.Drawing.Point(259, 205);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(75, 23);
            this.btnCad.TabIndex = 0;
            this.btnCad.Text = "Cadastro";
            this.btnCad.UseVisualStyleBackColor = true;
            // 
            // btnHub
            // 
            this.btnHub.Location = new System.Drawing.Point(340, 205);
            this.btnHub.Name = "btnHub";
            this.btnHub.Size = new System.Drawing.Size(75, 23);
            this.btnHub.TabIndex = 1;
            this.btnHub.Text = "Hub";
            this.btnHub.UseVisualStyleBackColor = true;
            this.btnHub.Click += new System.EventHandler(this.btnHub_Click);
            // 
            // btnPesc
            // 
            this.btnPesc.Location = new System.Drawing.Point(178, 205);
            this.btnPesc.Name = "btnPesc";
            this.btnPesc.Size = new System.Drawing.Size(75, 23);
            this.btnPesc.TabIndex = 2;
            this.btnPesc.Text = "Pesquisar";
            this.btnPesc.UseVisualStyleBackColor = true;
            // 
            // btnAlt
            // 
            this.btnAlt.Location = new System.Drawing.Point(97, 205);
            this.btnAlt.Name = "btnAlt";
            this.btnAlt.Size = new System.Drawing.Size(75, 23);
            this.btnAlt.TabIndex = 3;
            this.btnAlt.Text = "Alterar";
            this.btnAlt.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(16, 205);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 4;
            this.btnDel.Text = "Deletar";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Id Serviço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Valor";
            // 
            // txtIdServ
            // 
            this.txtIdServ.Location = new System.Drawing.Point(19, 58);
            this.txtIdServ.Name = "txtIdServ";
            this.txtIdServ.Size = new System.Drawing.Size(100, 20);
            this.txtIdServ.TabIndex = 9;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(19, 108);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 10;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(19, 157);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 11;
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(482, 304);
            this.Controls.Add(this.panel1);
            this.Name = "Form11";
            this.Text = "Serviço";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtIdServ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAlt;
        private System.Windows.Forms.Button btnPesc;
        private System.Windows.Forms.Button btnHub;
        private System.Windows.Forms.Button btnCad;
    }
}
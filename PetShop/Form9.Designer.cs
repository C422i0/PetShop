namespace PetShop
{
    partial class Form9
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
            this.label3 = new System.Windows.Forms.Label();
            this.Rua = new System.Windows.Forms.Label();
            this.Cidade = new System.Windows.Forms.Label();
            this.txtIdEnd = new System.Windows.Forms.TextBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.txtBar = new System.Windows.Forms.TextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.txtCid = new System.Windows.Forms.TextBox();
            this.btnCad = new System.Windows.Forms.Button();
            this.btnHub = new System.Windows.Forms.Button();
            this.btnPesc = new System.Windows.Forms.Button();
            this.btnAlt = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MintCream;
            this.panel1.Controls.Add(this.btnDel);
            this.panel1.Controls.Add(this.btnAlt);
            this.panel1.Controls.Add(this.btnPesc);
            this.panel1.Controls.Add(this.btnHub);
            this.panel1.Controls.Add(this.btnCad);
            this.panel1.Controls.Add(this.txtCid);
            this.panel1.Controls.Add(this.txtRua);
            this.panel1.Controls.Add(this.txtBar);
            this.panel1.Controls.Add(this.txtLog);
            this.panel1.Controls.Add(this.txtIdEnd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Rua);
            this.panel1.Controls.Add(this.Cidade);
            this.panel1.Location = new System.Drawing.Point(32, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 379);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "id Endereço";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Logradouro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Bairro";
            // 
            // Rua
            // 
            this.Rua.AutoSize = true;
            this.Rua.Location = new System.Drawing.Point(22, 179);
            this.Rua.Name = "Rua";
            this.Rua.Size = new System.Drawing.Size(27, 13);
            this.Rua.TabIndex = 4;
            this.Rua.Text = "Rua";
            // 
            // Cidade
            // 
            this.Cidade.AutoSize = true;
            this.Cidade.Location = new System.Drawing.Point(22, 236);
            this.Cidade.Name = "Cidade";
            this.Cidade.Size = new System.Drawing.Size(40, 13);
            this.Cidade.TabIndex = 5;
            this.Cidade.Text = "Cidade";
            // 
            // txtIdEnd
            // 
            this.txtIdEnd.Location = new System.Drawing.Point(25, 52);
            this.txtIdEnd.Name = "txtIdEnd";
            this.txtIdEnd.Size = new System.Drawing.Size(75, 20);
            this.txtIdEnd.TabIndex = 6;
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(25, 100);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(255, 20);
            this.txtLog.TabIndex = 7;
            // 
            // txtBar
            // 
            this.txtBar.Location = new System.Drawing.Point(25, 144);
            this.txtBar.Name = "txtBar";
            this.txtBar.Size = new System.Drawing.Size(255, 20);
            this.txtBar.TabIndex = 8;
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(25, 195);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(255, 20);
            this.txtRua.TabIndex = 9;
            // 
            // txtCid
            // 
            this.txtCid.Location = new System.Drawing.Point(25, 252);
            this.txtCid.Name = "txtCid";
            this.txtCid.Size = new System.Drawing.Size(255, 20);
            this.txtCid.TabIndex = 10;
            // 
            // btnCad
            // 
            this.btnCad.Location = new System.Drawing.Point(246, 353);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(75, 23);
            this.btnCad.TabIndex = 11;
            this.btnCad.Text = "Cadastrar";
            this.btnCad.UseVisualStyleBackColor = true;
            this.btnCad.Click += new System.EventHandler(this.btnCad_Click);
            // 
            // btnHub
            // 
            this.btnHub.Location = new System.Drawing.Point(327, 353);
            this.btnHub.Name = "btnHub";
            this.btnHub.Size = new System.Drawing.Size(75, 23);
            this.btnHub.TabIndex = 12;
            this.btnHub.Text = "Hub";
            this.btnHub.UseVisualStyleBackColor = true;
            this.btnHub.Click += new System.EventHandler(this.btnHub_Click);
            // 
            // btnPesc
            // 
            this.btnPesc.Location = new System.Drawing.Point(165, 353);
            this.btnPesc.Name = "btnPesc";
            this.btnPesc.Size = new System.Drawing.Size(75, 23);
            this.btnPesc.TabIndex = 13;
            this.btnPesc.Text = "Pesquisar";
            this.btnPesc.UseVisualStyleBackColor = true;
            this.btnPesc.Click += new System.EventHandler(this.btnPesc_Click);
            // 
            // btnAlt
            // 
            this.btnAlt.Location = new System.Drawing.Point(84, 353);
            this.btnAlt.Name = "btnAlt";
            this.btnAlt.Size = new System.Drawing.Size(75, 23);
            this.btnAlt.TabIndex = 14;
            this.btnAlt.Text = "Alterar";
            this.btnAlt.UseVisualStyleBackColor = true;
            this.btnAlt.Click += new System.EventHandler(this.btnAlt_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(3, 353);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 15;
            this.btnDel.Text = "Deletar";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(475, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form9";
            this.Text = "Endereço";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAlt;
        private System.Windows.Forms.Button btnPesc;
        private System.Windows.Forms.Button btnHub;
        private System.Windows.Forms.Button btnCad;
        private System.Windows.Forms.TextBox txtCid;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.TextBox txtBar;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.TextBox txtIdEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Rua;
        private System.Windows.Forms.Label Cidade;
    }
}
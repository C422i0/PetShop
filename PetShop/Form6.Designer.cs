namespace PetShop
{
    partial class Form6
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtPorte = new System.Windows.Forms.TextBox();
            this.txtRaca = new System.Windows.Forms.TextBox();
            this.btnHub = new System.Windows.Forms.Button();
            this.btnCadRaca = new System.Windows.Forms.Button();
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
            this.panel1.Controls.Add(this.btnCadRaca);
            this.panel1.Controls.Add(this.btnHub);
            this.panel1.Controls.Add(this.txtRaca);
            this.panel1.Controls.Add(this.txtPorte);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(28, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 237);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Raça";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Porte";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 20);
            this.textBox1.TabIndex = 3;
            // 
            // txtPorte
            // 
            this.txtPorte.Location = new System.Drawing.Point(21, 109);
            this.txtPorte.Name = "txtPorte";
            this.txtPorte.Size = new System.Drawing.Size(168, 20);
            this.txtPorte.TabIndex = 4;
            // 
            // txtRaca
            // 
            this.txtRaca.Location = new System.Drawing.Point(235, 52);
            this.txtRaca.Name = "txtRaca";
            this.txtRaca.Size = new System.Drawing.Size(64, 20);
            this.txtRaca.TabIndex = 5;
            // 
            // btnHub
            // 
            this.btnHub.Location = new System.Drawing.Point(316, 205);
            this.btnHub.Name = "btnHub";
            this.btnHub.Size = new System.Drawing.Size(54, 23);
            this.btnHub.TabIndex = 6;
            this.btnHub.Text = "Hub";
            this.btnHub.UseVisualStyleBackColor = true;
            this.btnHub.Click += new System.EventHandler(this.btnHub_Click);
            // 
            // btnCadRaca
            // 
            this.btnCadRaca.Location = new System.Drawing.Point(235, 205);
            this.btnCadRaca.Name = "btnCadRaca";
            this.btnCadRaca.Size = new System.Drawing.Size(75, 23);
            this.btnCadRaca.TabIndex = 7;
            this.btnCadRaca.Text = "Cadastrar";
            this.btnCadRaca.UseVisualStyleBackColor = true;
            this.btnCadRaca.Click += new System.EventHandler(this.btnCadRaca_Click);
            // 
            // btnPesc
            // 
            this.btnPesc.Location = new System.Drawing.Point(154, 205);
            this.btnPesc.Name = "btnPesc";
            this.btnPesc.Size = new System.Drawing.Size(75, 23);
            this.btnPesc.TabIndex = 8;
            this.btnPesc.Text = "Pesquisar";
            this.btnPesc.UseVisualStyleBackColor = true;
            this.btnPesc.Click += new System.EventHandler(this.btnPesc_Click);
            // 
            // btnAlt
            // 
            this.btnAlt.Location = new System.Drawing.Point(73, 205);
            this.btnAlt.Name = "btnAlt";
            this.btnAlt.Size = new System.Drawing.Size(75, 23);
            this.btnAlt.TabIndex = 9;
            this.btnAlt.Text = "Alterar";
            this.btnAlt.UseVisualStyleBackColor = true;
            this.btnAlt.Click += new System.EventHandler(this.btnAlt_Click);
            // 
            // btnDelet
            // 
            this.btnDelet.Location = new System.Drawing.Point(3, 205);
            this.btnDelet.Name = "btnDelet";
            this.btnDelet.Size = new System.Drawing.Size(64, 23);
            this.btnDelet.TabIndex = 10;
            this.btnDelet.Text = "Deletar";
            this.btnDelet.UseVisualStyleBackColor = true;
            this.btnDelet.Click += new System.EventHandler(this.btnDelet_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(427, 295);
            this.Controls.Add(this.panel1);
            this.Name = "Form6";
            this.Text = "Cadastro raça";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDelet;
        private System.Windows.Forms.Button btnAlt;
        private System.Windows.Forms.Button btnPesc;
        private System.Windows.Forms.Button btnCadRaca;
        private System.Windows.Forms.Button btnHub;
        private System.Windows.Forms.TextBox txtRaca;
        private System.Windows.Forms.TextBox txtPorte;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
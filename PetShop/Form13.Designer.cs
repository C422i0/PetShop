namespace PetShop
{
    partial class Form13
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdServicosVend = new System.Windows.Forms.TextBox();
            this.txtIdServicos = new System.Windows.Forms.TextBox();
            this.txtIdVenda = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtValorAtual = new System.Windows.Forms.TextBox();
            this.btnHub = new System.Windows.Forms.Button();
            this.btnCad = new System.Windows.Forms.Button();
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
            this.panel1.Controls.Add(this.btnCad);
            this.panel1.Controls.Add(this.btnHub);
            this.panel1.Controls.Add(this.txtValorAtual);
            this.panel1.Controls.Add(this.txtQuantidade);
            this.panel1.Controls.Add(this.txtIdVenda);
            this.panel1.Controls.Add(this.txtIdServicos);
            this.panel1.Controls.Add(this.txtIdServicosVend);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(39, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 362);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Serviços Vendidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id Serviços";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Id Venda";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantidade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Valor Atual";
            // 
            // txtIdServicosVend
            // 
            this.txtIdServicosVend.Location = new System.Drawing.Point(19, 32);
            this.txtIdServicosVend.Name = "txtIdServicosVend";
            this.txtIdServicosVend.Size = new System.Drawing.Size(127, 20);
            this.txtIdServicosVend.TabIndex = 5;
            // 
            // txtIdServicos
            // 
            this.txtIdServicos.Location = new System.Drawing.Point(19, 83);
            this.txtIdServicos.Name = "txtIdServicos";
            this.txtIdServicos.Size = new System.Drawing.Size(127, 20);
            this.txtIdServicos.TabIndex = 6;
            // 
            // txtIdVenda
            // 
            this.txtIdVenda.Location = new System.Drawing.Point(19, 138);
            this.txtIdVenda.Name = "txtIdVenda";
            this.txtIdVenda.Size = new System.Drawing.Size(127, 20);
            this.txtIdVenda.TabIndex = 7;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(19, 198);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(127, 20);
            this.txtQuantidade.TabIndex = 8;
            // 
            // txtValorAtual
            // 
            this.txtValorAtual.Location = new System.Drawing.Point(19, 261);
            this.txtValorAtual.Name = "txtValorAtual";
            this.txtValorAtual.Size = new System.Drawing.Size(127, 20);
            this.txtValorAtual.TabIndex = 9;
            // 
            // btnHub
            // 
            this.btnHub.Location = new System.Drawing.Point(327, 336);
            this.btnHub.Name = "btnHub";
            this.btnHub.Size = new System.Drawing.Size(75, 23);
            this.btnHub.TabIndex = 10;
            this.btnHub.Text = "Hub";
            this.btnHub.UseVisualStyleBackColor = true;
            this.btnHub.Click += new System.EventHandler(this.btnHub_Click);
            // 
            // btnCad
            // 
            this.btnCad.Location = new System.Drawing.Point(246, 336);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(75, 23);
            this.btnCad.TabIndex = 11;
            this.btnCad.Text = "Cadastrar";
            this.btnCad.UseVisualStyleBackColor = true;
            // 
            // btnPesc
            // 
            this.btnPesc.Location = new System.Drawing.Point(165, 336);
            this.btnPesc.Name = "btnPesc";
            this.btnPesc.Size = new System.Drawing.Size(75, 23);
            this.btnPesc.TabIndex = 12;
            this.btnPesc.Text = "Pesquisar";
            this.btnPesc.UseVisualStyleBackColor = true;
            // 
            // btnAlt
            // 
            this.btnAlt.Location = new System.Drawing.Point(84, 336);
            this.btnAlt.Name = "btnAlt";
            this.btnAlt.Size = new System.Drawing.Size(75, 23);
            this.btnAlt.TabIndex = 13;
            this.btnAlt.Text = "Alterar";
            this.btnAlt.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(3, 336);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 14;
            this.btnDel.Text = "Deletar";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // Form13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(504, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form13";
            this.Text = "Form13";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAlt;
        private System.Windows.Forms.Button btnPesc;
        private System.Windows.Forms.Button btnCad;
        private System.Windows.Forms.Button btnHub;
        private System.Windows.Forms.TextBox txtValorAtual;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtIdVenda;
        private System.Windows.Forms.TextBox txtIdServicos;
        private System.Windows.Forms.TextBox txtIdServicosVend;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
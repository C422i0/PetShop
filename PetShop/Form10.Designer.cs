namespace PetShop
{
    partial class Form10
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
            this.txtIdAgenda = new System.Windows.Forms.TextBox();
            this.txtIdVenda = new System.Windows.Forms.TextBox();
            this.txtPago = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
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
            this.panel1.Controls.Add(this.monthCalendar1);
            this.panel1.Controls.Add(this.txtPago);
            this.panel1.Controls.Add(this.txtIdVenda);
            this.panel1.Controls.Add(this.txtIdAgenda);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(32, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 367);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id Agenda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Id Venda";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Pago";
            // 
            // txtIdAgenda
            // 
            this.txtIdAgenda.Location = new System.Drawing.Point(23, 55);
            this.txtIdAgenda.Name = "txtIdAgenda";
            this.txtIdAgenda.Size = new System.Drawing.Size(100, 20);
            this.txtIdAgenda.TabIndex = 5;
            // 
            // txtIdVenda
            // 
            this.txtIdVenda.Location = new System.Drawing.Point(23, 101);
            this.txtIdVenda.Name = "txtIdVenda";
            this.txtIdVenda.Size = new System.Drawing.Size(100, 20);
            this.txtIdVenda.TabIndex = 6;
            // 
            // txtPago
            // 
            this.txtPago.Location = new System.Drawing.Point(23, 148);
            this.txtPago.Name = "txtPago";
            this.txtPago.Size = new System.Drawing.Size(100, 20);
            this.txtPago.TabIndex = 8;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(175, 132);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 9;
            // 
            // btnCad
            // 
            this.btnCad.Location = new System.Drawing.Point(246, 341);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(75, 23);
            this.btnCad.TabIndex = 10;
            this.btnCad.Text = "Cadastro";
            this.btnCad.UseVisualStyleBackColor = true;
            this.btnCad.Click += new System.EventHandler(this.btnCad_Click);
            // 
            // btnHub
            // 
            this.btnHub.Location = new System.Drawing.Point(327, 341);
            this.btnHub.Name = "btnHub";
            this.btnHub.Size = new System.Drawing.Size(75, 23);
            this.btnHub.TabIndex = 11;
            this.btnHub.Text = "Hub";
            this.btnHub.UseVisualStyleBackColor = true;
            this.btnHub.Click += new System.EventHandler(this.btnHub_Click);
            // 
            // btnPesc
            // 
            this.btnPesc.Location = new System.Drawing.Point(165, 341);
            this.btnPesc.Name = "btnPesc";
            this.btnPesc.Size = new System.Drawing.Size(75, 23);
            this.btnPesc.TabIndex = 12;
            this.btnPesc.Text = "Pesquisa";
            this.btnPesc.UseVisualStyleBackColor = true;
            this.btnPesc.Click += new System.EventHandler(this.btnPesc_Click);
            // 
            // btnAlt
            // 
            this.btnAlt.Location = new System.Drawing.Point(84, 341);
            this.btnAlt.Name = "btnAlt";
            this.btnAlt.Size = new System.Drawing.Size(75, 23);
            this.btnAlt.TabIndex = 13;
            this.btnAlt.Text = "Altura";
            this.btnAlt.UseVisualStyleBackColor = true;
            this.btnAlt.Click += new System.EventHandler(this.btnAlt_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(3, 341);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 14;
            this.btnDel.Text = "Deletar";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(484, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form10";
            this.Text = "Agenda";
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
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox txtPago;
        private System.Windows.Forms.TextBox txtIdVenda;
        private System.Windows.Forms.TextBox txtIdAgenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
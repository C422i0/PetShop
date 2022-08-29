namespace PetShop
{
    partial class Form4
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
            this.txtNomeAnimal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEsp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGen = new System.Windows.Forms.TextBox();
            this.CalendNasc = new System.Windows.Forms.MonthCalendar();
            this.label = new System.Windows.Forms.Label();
            this.txtIdRaca = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.btnBackHub = new System.Windows.Forms.Button();
            this.btnCadAni = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MintCream;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnCadAni);
            this.panel1.Controls.Add(this.btnBackHub);
            this.panel1.Controls.Add(this.txtIdCliente);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtIdRaca);
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.CalendNasc);
            this.panel1.Controls.Add(this.txtGen);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtEsp);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNomeAnimal);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(34, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 350);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do animal";
            // 
            // txtNomeAnimal
            // 
            this.txtNomeAnimal.Location = new System.Drawing.Point(25, 38);
            this.txtNomeAnimal.Name = "txtNomeAnimal";
            this.txtNomeAnimal.Size = new System.Drawing.Size(245, 20);
            this.txtNomeAnimal.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Especie";
            // 
            // txtEsp
            // 
            this.txtEsp.Location = new System.Drawing.Point(25, 88);
            this.txtEsp.Name = "txtEsp";
            this.txtEsp.Size = new System.Drawing.Size(245, 20);
            this.txtEsp.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gênero";
            // 
            // txtGen
            // 
            this.txtGen.Location = new System.Drawing.Point(25, 140);
            this.txtGen.Name = "txtGen";
            this.txtGen.Size = new System.Drawing.Size(137, 20);
            this.txtGen.TabIndex = 5;
            // 
            // CalendNasc
            // 
            this.CalendNasc.Location = new System.Drawing.Point(294, 140);
            this.CalendNasc.Name = "CalendNasc";
            this.CalendNasc.TabIndex = 6;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(22, 174);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(60, 13);
            this.label.TabIndex = 8;
            this.label.Text = "Id da Raça";
            // 
            // txtIdRaca
            // 
            this.txtIdRaca.Location = new System.Drawing.Point(25, 190);
            this.txtIdRaca.Name = "txtIdRaca";
            this.txtIdRaca.Size = new System.Drawing.Size(137, 20);
            this.txtIdRaca.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "id Cliente";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(25, 238);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(137, 20);
            this.txtIdCliente.TabIndex = 11;
            // 
            // btnBackHub
            // 
            this.btnBackHub.Location = new System.Drawing.Point(460, 319);
            this.btnBackHub.Name = "btnBackHub";
            this.btnBackHub.Size = new System.Drawing.Size(77, 23);
            this.btnBackHub.TabIndex = 12;
            this.btnBackHub.Text = "Hub";
            this.btnBackHub.UseVisualStyleBackColor = true;
            this.btnBackHub.Click += new System.EventHandler(this.btnBackHub_Click);
            // 
            // btnCadAni
            // 
            this.btnCadAni.Location = new System.Drawing.Point(331, 319);
            this.btnCadAni.Name = "btnCadAni";
            this.btnCadAni.Size = new System.Drawing.Size(123, 23);
            this.btnCadAni.TabIndex = 13;
            this.btnCadAni.Text = "Cadastrar novo animal";
            this.btnCadAni.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Data de nascimento";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(636, 432);
            this.Controls.Add(this.panel1);
            this.Name = "Form4";
            this.Text = "2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEsp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeAnimal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBackHub;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdRaca;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.MonthCalendar CalendNasc;
        private System.Windows.Forms.TextBox txtGen;
        private System.Windows.Forms.Button btnCadAni;
        private System.Windows.Forms.Label label4;
    }
}
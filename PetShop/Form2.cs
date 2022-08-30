using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }      
        private void btnLogOff_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }

        private void btnCadastroUsu_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            this.Hide();
            form.Show();
        }

        private void btnCadAni_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            this.Hide();
            form.Show();
        }

        private void btnCadCli_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            this.Hide();
            form.Show();
        }

        private void btnCadRac_Click(object sender, EventArgs e)
        {
            Form6 form = new Form6();
            this.Hide();
            form.Show();
        }

        private void btnCadTel_Click(object sender, EventArgs e)
        {
            Form7 form = new Form7();
            this.Hide();
            form.Show();
        }

        private void btnNovaVenda_Click(object sender, EventArgs e)
        {
            Form8 form = new Form8();
            this.Hide();
            form.Show();
        }
    }
}

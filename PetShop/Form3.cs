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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnCadasto_Click(object sender, EventArgs e)
        {
            if (txtCadNome.Text == "")
            {
                MessageBox.Show("Termine de se cadastrar primeiro amigo!");
            }
            else

            {
                Form1 form = new Form1();
                this.Hide();
                form.Show();
            }            
        }

        private void btnCadHub_Click(object sender, EventArgs e)
        {
            if (txtCadNome.Text == "")
            {
                MessageBox.Show("Termine de se cadastrar primeiro amigo!");
            }
            else
            {
                Form2 form = new Form2();
                this.Hide();
                form.Show();
            }
        }

        private void btnVolta_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            this.Hide();
            form.Show();
        }

        private void btnPesc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usuario Encontrado");
        }

        private void btnAlt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usuario alterado com sucesso!");
        }

        private void btnDelet_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usuario deletado com sucesso!");
        }
    }
}

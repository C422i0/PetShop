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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void btnHub_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            this.Hide();
            form.Show();
        }

        private void btnCadRaca_Click(object sender, EventArgs e)
        {
            if (txtRaca.Text =="" ^ txtPorte.Text =="")
            {
                MessageBox.Show("Termine de cadastrar primeiro amigo!");
            }
            else
            {
                MessageBox.Show("Raça cadastrado com sucesso!");
            }
        }

        private void btnPesc_Click(object sender, EventArgs e)
        {
             MessageBox.Show("Raça Encontrada");
        }

        private void btnAlt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Raça alterado com sucesso!");
        }

        private void btnDelet_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Raça deletado com sucesso!");
        }
    }
}

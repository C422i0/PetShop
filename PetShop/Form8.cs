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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void btnHub_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            this.Hide();
            form.Show();
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            if (txtIdCliente.Text == "" && txtIdVenda.Text == "")
            {
                MessageBox.Show("Termine de cadastrar primeiro amigo!");
            }
            else
            {
                MessageBox.Show("Nova venda cadastrada com sucesso!");
            }
        }

        private void btnPesc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nova venda encontrada!");
        }

        private void btnAlt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nova venda alterada!");
        }

        private void btnDelet_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nova venda deletada!");
        }
    }
}

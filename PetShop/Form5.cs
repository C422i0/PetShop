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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnBackHub_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            this.Hide();
            form.Show();
        }

        private void BtnCad_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text =="" ^ txtNomeCliente.Text =="" ^ txtNumeroCasa.Text =="" ^ txtIdCliente.Text=="" ^ txtIdEndereco.Text=="")
            {
                MessageBox.Show("Primeiro termine de cadastrar o cliente!");
            }
            else
            {
                MessageBox.Show("Cliente cadastrado com sucesso");
            }
        }

        private void btnPesc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cliente Encontrado");
        }

        private void btnAlt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cliente alterado com sucesso!");
        }

        private void btnDelet_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cliente deletado com sucesso!");
        }
    }
}

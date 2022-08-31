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
    public partial class Form7 : Form
    {
        public Form7()
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
            if (txtIdCliente.Text == "")
            {
                MessageBox.Show("Termine de cadastrar o telefone primeiro!");
            
                    }
            
            else
            {
                MessageBox.Show("Telefone cadastrado com sucesso!");
                
            }
            
        }

        private void btnPesc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Telefone Encontrado!");
        }

        private void btnAlt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Telefone alterado!");
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Telefone deletado com sucesso!");
        }
    }
}

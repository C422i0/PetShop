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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnBackHub_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            this.Hide();
            form.Show();
        }

        private void btnCadAni_Click(object sender, EventArgs e)
        {
            if (txtNomeAnimal.Text == "" ^ txtGen.Text=="" ^ txtEsp.Text=="" ^ txtIdCliente.Text=="" ^ txtIdRaca.Text=="")
            {
                MessageBox.Show("Termine de cadastrar o animal primeiro!");
            }
            else

            {
                MessageBox.Show("Animal cadastrado com sucesso!");
            }
        }

        private void btnPesc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Animal Encontrado");
        }

        private void btnAlt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Animal alterado com sucesso!");
        }

        private void btnDelet_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Animal deletado com sucesso!");
        }
    }
}

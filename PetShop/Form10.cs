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
    public partial class Form10 : Form
    {
        public Form10()
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
            if (txtIdAgenda.Text == "")
            {
                MessageBox.Show("Termine de agendar primeiro amigo!");
            }
            else
            {
                MessageBox.Show("Agendamento cadastrado com sucesso!");
            }
        }

        private void btnPesc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Agendamento cadastrado com sucesso!");
        }

        private void btnAlt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Agendamento alterado com sucesso!");
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Agendamento deletado com sucesso!");
        }
    }
}

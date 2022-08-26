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
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoPO2_4bim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            string cpf = maskedTextBox1.Text;
            bool validaCPF = Validacoes.ValidarCPF(cpf);
            if (validaCPF)
            {
                MessageBox.Show(validaCPF.ToString());
                Menu m = new Menu();
                m.ShowDialog();
               
            }
            
            else
            {
                MessageBox.Show("CPF não existente", "Tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
           

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}

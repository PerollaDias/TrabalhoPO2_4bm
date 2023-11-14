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
    public partial class Cadastra_Cliente : Form
    {
        public Cadastra_Cliente()
        {
            InitializeComponent();
        }

        private void Cadastra_Cliente_Load(object sender, EventArgs e)
        {

        }

        private void bt_cadastrar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tx_Nome.Text) || String.IsNullOrEmpty(maskedTextBox1.Text) || String.IsNullOrEmpty(maskedTextBox3.Text) 
                || String.IsNullOrEmpty(maskedTextBox2.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Cliente novoCliente = new Cliente();
                {
                    novoCliente.Nome = tx_Nome.Text;
                    novoCliente.Cpf = maskedTextBox1.Text;
                    novoCliente.Nascimento = maskedTextBox3.Text;
                    novoCliente.Telefone = maskedTextBox2.Text;
                };

                MessageBox.Show("Cliente cadastrado com sucesso!", "Cadastro efetuado", MessageBoxButtons.OK, MessageBoxIcon.Information);

               
            }
            string cpf = maskedTextBox1.Text;
            bool validaCPF = Validacoes.ValidarCPF(cpf);
            MessageBox.Show(validaCPF.ToString());

        }

        private void tx_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_excluir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tx_Nome.Clear();
            maskedTextBox1.Clear();
            maskedTextBox3.Clear();
            maskedTextBox2.Clear();
        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

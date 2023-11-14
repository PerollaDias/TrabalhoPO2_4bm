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
    public partial class Cadastrar_Funcionário : Form
    {
        public Cadastrar_Funcionário()
        {
            InitializeComponent();
        }

        private void Cadastrar_Funcionário_Load(object sender, EventArgs e)
        {

        }

        private void bt_cadastrar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tx_Nome.Text) || String.IsNullOrEmpty(maskedTextBox1.Text) || String.IsNullOrEmpty(maskedTextBox3.Text)
                || String.IsNullOrEmpty(maskedTextBox2.Text) || String.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Funcionario novoFuncionario = new Funcionario();
                {
                    novoFuncionario.nome = tx_Nome.Text;
                    novoFuncionario.cargo = comboBox1.Text;
                    novoFuncionario.cpf = maskedTextBox1.Text;
                    novoFuncionario.nascimento = maskedTextBox3.Text;
                    novoFuncionario.tel = maskedTextBox2.Text;
             
                };

                MessageBox.Show("Funcionário cadastrado com sucesso!", "Cadastro efetuado", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            string cpf = maskedTextBox1.Text;
            bool validaCPF = Validacoes.ValidarCPF(cpf);
            MessageBox.Show(validaCPF.ToString());
        }

        private void tx_Nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void bt_excluir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tx_Nome.Clear();
            maskedTextBox1.Clear();
            maskedTextBox3.Clear();
            maskedTextBox2.Clear();
            comboBox1.Text.Clone();
        }
    }
}

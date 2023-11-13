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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cadastra_Cliente Ccliente = new Cadastra_Cliente();
            Ccliente.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cadastrar_Funcionário Cfun = new Cadastrar_Funcionário();
            Cfun.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cadastrar_Fornecedor Cfor = new Cadastrar_Fornecedor();
            Cfor.ShowDialog();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Cadastra_Cliente Ccliente = new Cadastra_Cliente();
            Ccliente.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Cadastrar_Funcionário Cfun = new Cadastrar_Funcionário();
            Cfun.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Cadastrar_Fornecedor Cfor = new Cadastrar_Fornecedor();
            Cfor.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Plano_de_treino planT = new Plano_de_treino();
            planT.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Controle_de_acesso control = new Controle_de_acesso();
            control.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

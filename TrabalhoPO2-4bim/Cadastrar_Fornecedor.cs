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
    public partial class Cadastrar_Fornecedor : Form
    {
        public Cadastrar_Fornecedor()
        {
            InitializeComponent();
        }

        private void Cadastrar_Fornecedor_Load(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Cadastrar_Fornecedor
            // 
            this.BackgroundImage = global::TrabalhoPO2_4bim.Properties.Resources.Black_Modern_Gym_Fitness__Poster_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(535, 476);
            this.DoubleBuffered = true;
            this.Name = "Cadastrar_Fornecedor";
            this.ResumeLayout(false);

        }
    }
}

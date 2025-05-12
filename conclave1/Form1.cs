using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conclave1
{
    public partial class Form1 : Form
    {
        string[][] dados;
        public Form1()
        {
            InitializeComponent();

            dados = new string[300][];
        }

        public void ReceberDados(string[][] dados)
        {
            this.dados = dados;
        }

        private void btGerenciar_Click(object sender, EventArgs e)
        {
            FrnGerenciar f = new FrnGerenciar(this, dados); //cria uma variável
            f.Show(); //abre o formulário
            this.Hide();//esconde o principal
        }
    }
}

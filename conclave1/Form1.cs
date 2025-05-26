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
        string[][] dados;   // armazena os dados dos cardeais, onde cada cardeal é representado por um array de strings
        public Form1()
        {
            InitializeComponent(); //inicializa os componentes do formulário

            dados = new string[300][]; //inicializa o array de dados com 300 posições
        }

        public void ReceberDados(string[][] dados)
        {
            this.dados = dados; //recebe os dados do formulário de gerenciamento
        }

        private void btGerenciar_Click(object sender, EventArgs e)
        {
            FrnGerenciar f = new FrnGerenciar(this, dados); //cria uma variável
            f.Show(); //abre o formulário
            this.Hide();//esconde o principal
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btVotar_Click(object sender, EventArgs e)
        {
            FrnVotar f = new FrnVotar(this, dados); //cria uma variável do formulário de votação
            f.ShowDialog(); //abre o formulário de votação como um diálogo modal, bloqueando a interação com o formulário principal até que o diálogo seja fechado
        }
    }
}

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

        private void btResultado_Click(object sender, EventArgs e)
        {
            {
                DialogResult confirmar = MessageBox.Show("Deseja encerrar a votação?", "Encerrar Votação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmar == DialogResult.No)
                    return;

                int totalVotos = 0;
                for (int i = 0; i < dados.Length; i++)
                {
                    if (dados[i] != null && !string.IsNullOrEmpty(dados[i][0]))
                    {
                        int votos = int.Parse(dados[i][1]);
                        totalVotos += votos;
                    }
                }

                int doisTerços = (int)Math.Ceiling(totalVotos * 2.0 / 3.0);
                int eleitoIndex = -1;

                for (int i = 0; i < dados.Length; i++)
                {
                    if (dados[i] != null && !string.IsNullOrEmpty(dados[i][0]))
                    {
                        int votos = int.Parse(dados[i][1]);
                        if (votos >= doisTerços)
                        {
                            eleitoIndex = i;
                            break;
                        }
                    }
                }

                if (eleitoIndex == -1)
                {
                    MessageBox.Show("Nenhum cardeal atingiu os 2/3 dos votos. Não houve vitorioso.", "Resultado");
                    for (int i = 0; i < dados.Length; i++)
                    {
                        if (dados[i] != null)
                            dados[i][1] = "0";
                    }
                }
                else
                {
                    string nomeEleito = dados[eleitoIndex][0];
                    DialogResult aceita = MessageBox.Show($"{nomeEleito} foi eleito. Você aceita a eleição canônica à Sumo Pontífice?", "Eleição", MessageBoxButtons.YesNo);

                    if (aceita == DialogResult.Yes)
                    {
                        MessageBox.Show("HABEMUS PAPAM", "Eleição Finalizada");
                        for (int i = 0; i < dados.Length; i++)
                        {
                            dados[i] = null; // reinicia todo o vetor
                        }
                    }
                    else
                    {
                        for (int i = 0; i < dados.Length; i++)
                        {
                            if (dados[i] != null) 
                                dados[i][1] = "0"; // zera os votos
                        }
                    }
                }
            }
        }
    }
}

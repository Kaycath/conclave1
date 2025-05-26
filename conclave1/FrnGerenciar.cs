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
    public partial class FrnGerenciar : Form
    {
        string[][] dados; // armazena os dados dos cardeais, onde cada cardeal é representado por um array de strings
        Form1 anterior; // armazena a referência do formulário principal para poder atualizá-lo posteriormente
        public FrnGerenciar(Form1 anterior, string[][] dados) // construtor da classe FrnGerenciar, que recebe o formulário principal e os dados dos cardeais
        {
            InitializeComponent(); // inicializa os componentes do formulário de gerenciamento
            this.anterior = anterior; // armazena a referência do formulário principal para poder atualizá-lo posteriormente
            this.dados = dados; // armazena a referência do formulário principal e os dados dos cardeais

            Atualizar(); // chama o método Atualizar para preencher o DataGridView com os cardeais cadastrados
        }

        int Length(string[][] v) // método para contar quantos cardeais estão cadastrados na lista
        {
            int q = 0; // variável para contar quantos cardeais estão cadastrados na lista
            for (int i = 0; i < v.Length; i++) // percorre o array de cardeais para contar quantos estão cadastrados
            {
                if (v[i] != null) // verifica se a posição do array não é nula
                    q++;
            }
            return q; // conta quantos cardeais estão cadastrados na lista
        }
        

        private void FrnGerenciar_FormClosed(object sender, FormClosedEventArgs e)
        {
            anterior.ReceberDados(dados); // atualiza os dados no formulário principal quando o formulário de gerenciamento é fechado
            anterior.Show(); // exibe o formulário principal novamente quando o formulário de gerenciamento é fechado
        }

        void Atualizar()
        {
            dgvCardeais.Rows.Clear(); // limpa todas as linhas do DataGridView antes de atualizar
            for (int i = 0;i < Length(dados); i++) // percorre a lista de cardeais para atualizar o DataGridView
            {
                DataGridViewRow linha = new DataGridViewRow(); // cria uma nova linha para o DataGridView
                linha.CreateCells(dgvCardeais); // cria uma nova linha no DataGridView com o mesmo número de células que o DataGridView possui
                linha.Cells[0].Value = dados[i][0]; // define o nome do cardeal na primeira célula da linha
                dgvCardeais.Rows.Add(linha); // adiciona a linha ao DataGridView
            }
        }

        private void btAdiciona_Click(object sender, EventArgs e)
        {
            if (Length(dados) == dados.Length) // verifica se a lista de cardeais está cheia
            { // verifica se a lista de cardeais está cheia
                MessageBox.Show("Lista cheia!"); // exibe uma mensagem de erro se a lista estiver cheia
                return;
            }

            string nome = txtNome.Text.Trim(); // remove espaços em branco no início e no final do nome
            if (String.IsNullOrEmpty(nome)) // verifica se o nome é vazio ou nulo
            {
                MessageBox.Show("Insira um nome válido"); //verifica se o nome é vazio ou nulo
                return ; 
            }

            if(Funcoes.Buscar(nome, dados) > -1) // verifica se o nome já está cadastrado na lista de cardeais
            {
                MessageBox.Show($"{nome} já cadastrado!"); //o $ é para variável concatenad entre chaves
                return ;
            }

            dados[Funcoes.Length (dados)] = new string[] { nome, "0" }; // adiciona um novo cardeal à lista de cardeais com o nome e 0 votos

            Atualizar(); // chama o método Atualizar para atualizar a lista de cardeais exibida no DataGridView
            txtNome.Text = ""; // limpa o campo de texto para inserir um novo nome
        }
    }
}

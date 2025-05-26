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
    public partial class FrnVotar : Form
    {
        Form1 anterior;
        string[][] cardeais; // armazena a lista de cardeais

        public FrnVotar(Form1 anterior, string[][] cardeais) // construtor da classe FrnVotar
        {
            InitializeComponent(); // inicializa os componentes do formulário
            this.anterior = anterior; // armazena a referência do formulário principal
            this.cardeais = cardeais; // armazena a referência do formulário principal e a lista de cardeais
            Carregar(); // chama o método Carregar para preencher a lista de cardeais
        }

        void Carregar()
        { // Carrega os cardeais na lista de seleção
            foreach (string[] dados in cardeais) // percorre cada cardeal na lista de cardeais
                if (dados != null)
                    lbxCardeais.Items.Add(dados[0]); // adiciona o nome de cada cardeal na lista de seleção
        }

        private void btVotar_Click(object sender, EventArgs e)
        {
            btVotar.Enabled = false;
            {
                if (lbxCardeais.SelectedItems.Count != 1) // verifica se apenas um cardeal foi selecionado na lista
                {
                    MessageBox.Show("Selecione apenas um cardeal para votar."); // exibe uma mensagem de erro se não houver um cardeal selecionado
                    return;
                }

                string nome = lbxCardeais.SelectedItem.ToString(); // obtém o nome do cardeal selecionado na lista
                int index = Funcoes.Buscar(nome, cardeais); // busca o índice do cardeal selecionado na lista de cardeais

                int votos = int.Parse(cardeais[index][1]);// obtém o número de votos do cardeal selecionado
                votos++;
                cardeais[index][1] = votos.ToString(); // atualiza o número de votos do cardeal selecionado

                anterior.ReceberDados(cardeais); // atualiza os dados no formulário principal
                this.Close(); //fecha o formulário atual
            }
        }
    }

}
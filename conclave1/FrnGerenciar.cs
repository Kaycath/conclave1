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
        string[][] dados;
        Form1 anterior;
        public FrnGerenciar(Form1 anterior, string[][] dados)
        {
            InitializeComponent();
            this.anterior = anterior;
            this.dados = dados;

            Atualizar();
        }

        int Length(string[][] v)
        {
            int q = 0;
            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] != null)
                    q++;
            }
            return q;
        }

        int Buscar(string nome)
        {
            int indice;
            for(indice = 0; indice < Length(dados) && dados[indice][0] != nome; indice++);

            if (indice < Length(dados))
                return indice;
            return -1; //codigo universal de erro quando o retorno eh inteiro
        }

        private void FrnGerenciar_FormClosed(object sender, FormClosedEventArgs e)
        {
            anterior.ReceberDados(dados);
            anterior.Show();
        }

        void Atualizar()
        {
            dgvCardeais.Rows.Clear();
            for (int i = 0;i < Length(dados); i++)
            {
                DataGridViewRow linha = new DataGridViewRow();
                linha.CreateCells(dgvCardeais);
                linha.Cells[0].Value = dados[i][0];
                dgvCardeais.Rows.Add(linha);
            }
        }

        private void btAdiciona_Click(object sender, EventArgs e)
        {
            if (Length(dados) == dados.Length)
            {
                MessageBox.Show("Lista cheia!");
                return;
            }

            string nome = txtNome.Text.Trim();
            if (String.IsNullOrEmpty(nome))
            {
                MessageBox.Show("Insira um nome válido");
                return ;
            }

            if(Buscar(nome) > -1)
            {
                MessageBox.Show($"{nome} já cadastrado!"); //o $ é para variável concatenad entre chaves
                return ;
            }

            dados[Length(dados)] = new string[] { nome, "0" };

            Atualizar();
            txtNome.Text = "";
        }
    }
}

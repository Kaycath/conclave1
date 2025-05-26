using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conclave1
{
    public class Funcoes
    {

        public static int Length(string[][] v)
        {
            int q = 0;
            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] != null)
                    q++;
            }
            return q;
        }   

        public static int Buscar(string nome, string[][] dados)
        {
            int indice;
            for (indice = 0; indice < Length(dados) && dados[indice][0] != nome; indice++) ;

            if (indice < Length(dados))
                return indice;
            return -1; //codigo universal de erro quando o retorno eh inteiro
        }
    }
}

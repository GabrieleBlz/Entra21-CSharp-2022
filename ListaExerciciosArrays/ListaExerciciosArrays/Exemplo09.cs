using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Ordenar Arrays.
// Ordenar por ordem descrescente um array de 9 inteiros.

namespace ListaExemplosArrays
{
    internal class Exemplo09
    {
        public void Executar()
        {
            int[] lista = new int[9];
            int maior, pos, troca;
            string linha = "";
            int conta = 1;

            Console.WriteLine("Introduza os dados do array: ");
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine("Pos " + i);
                lista[i] = int.Parse(Console.ReadLine());
            }
            linha = "Lista: [";
            for (int i = 0; i < 9; i++)
            {
                linha = linha + lista[i] + " ";
            }
            linha = linha + "]";
            Console.WriteLine(linha);

            // Ordenar por ordem Descrescente.
            for (int i = 0; i < 8; i++)
            {
                maior = lista[i];
                pos = i;
                troca = i;
                for (int j = i + 1; j < 9; j++)
                {
                    if (maior < lista[j])
                    {
                        maior = lista[j];
                        pos = j;
                    }
                }

                // Troca lista[i] com lista[pos].
                troca = lista[i];
                lista[i] = lista[pos];
                lista[pos] = troca;
            }
            linha = "Lista ordenada: [";
            for (int i = 0; i < 9; i++)
            {
                linha = linha + lista[i] + " ";
            }
            linha = linha + "]";
            Console.WriteLine(linha);
            Console.ReadKey();
            Console.Clear();
        }
    }
}

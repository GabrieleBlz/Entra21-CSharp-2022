using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Soma de elementos de sequência.
// Ler uma sequência de 20 números inteiros positivos e calcular a soma dos números menores do que 10.

namespace ListaExemplosArrays
{
    internal class Exemplo10
    {
        public void Executar()
        {
            int[] lista = new int[20];
            int conta = 0;
            int num = 0;
            int soma = 0;

            while (conta < 20)
            {
                num = int.Parse(Console.ReadLine());
                if (num >= 0)
                {
                    conta = conta + 1;
                    lista[conta - 1] = num;
                    if (num < 10) soma = soma + 1;
                }
            }
            Console.WriteLine("Soma dos números menores de 10 " + soma);
            Console.ReadKey();
            Console.Clear();
        }
    }
}

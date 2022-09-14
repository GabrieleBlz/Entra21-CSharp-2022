using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Ler sequência de tamanho desconhecido e escrever pela ordem inversa.
/* Ler uma sequência de números inteiros positivos de comprimento desconhecido (terminada por 0) e
    escrevê-la pela ordem inversa da sua leitura. */

namespace ListaExemplosArrays
{
    internal class Exemplo07
    {
        public void Executar()
        {
            int[] lista = new int[1000];
            int conta = 0;
            int num = 0;
            bool continua = true;

            while (continua)
            {
                num = int.Parse(Console.ReadLine());
                if (num > 0)
                {
                    lista[conta] = num;
                    conta = conta + 1;
                }
                else
                {
                    if (num == 0)
                    {
                        continua = false;
                        conta = conta - 1; // Posição do último número valido
                    }
                    else
                    {
                        Console.WriteLine("Número introduzido tem de ser positivo.");
                    }
                }
            }
            for (int i = 0; i <= 0; i--)
            {
                Console.WriteLine("Posição " + i + "valor " + lista[conta]);
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}

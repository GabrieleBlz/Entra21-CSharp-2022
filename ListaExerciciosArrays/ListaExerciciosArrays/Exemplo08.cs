using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Operação de manipulação de Array.
/* Ler uma sequência de 20 números inteiros para um array, e:
   Para cada elemento do array, escreva na consola o seu valor e a sua posição, começando na primeira posição;
   Para cada elemento do array, escreva na consola o seu valor e a sua posição, começando na última posição e terminando na primeira posição;
   Inverta a posição dos elementos do array;
   Some o valor 10 a cada elemento do array.
*/

namespace ListaExemplosArrays
{
    internal class Exemplo08
    {
        public void Executar()
        {
            int[] lista = new int[20];
            
            for (int i = 0; i < lista.Length; i++)
            {
                Console.WriteLine("Introduza um valor inteiro: ");
                lista[i] = int.Parse(Console.ReadLine());
            }

            // Para cada elemento do array, escreva no console o seu valor e a sua posição, começando na primeira posição.
            for (int i = 0; i < lista.Length; i++)
            {
                Console.WriteLine("Posição " + i + "valor " + lista[i]);
            }

            // Para cada elemento do array, escreva no console o seu valor e a sua posição, começando na última posição e terminando na primeira posição.
            for (int i = lista.Length - 1; i > 0; i--)
            {
                Console.WriteLine("Posição " + i + "valor " + lista[i]);
            }

            // Inverta a posição dos elementos do array.
            int aux = 0;
            for (int i = 0; i <= (lista.Length / 2) - 1; i++)
            {
                aux = lista[i];
                lista[i] = lista[lista.Length - i];
            }

            // Some o valor 10 a cada elemento do array.
            for (int i = 0; i < lista.Length; i++)
            {
                lista[i] = lista[i] + 10;
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Crie um código que ao digitar 3 números ele imprima o número menor

namespace ListaExercicios
{
    internal class Exercicio06
    {
        public void Executar()
        {
            Console.WriteLine("Informe o 1º número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o 2º número: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o 3º número: ");
            int num3 = int.Parse(Console.ReadLine());

            if (num1 < num2 && num1 < num3)
            {
                Console.WriteLine("O menor número é {0}...", num1);
            }
            else if (num2 < num1 && num2 < num3)
            {
                Console.WriteLine("O menor número é {0}...", num2);
            }
            else if (num3 < num1 && num3 < num2)
            {
                Console.WriteLine("O menor número é {0}...", num3);
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}

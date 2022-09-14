using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    internal class Exercicio01
    {
        public void Executar()
        {
            Console.WriteLine("Informe o 1º número: ");
            int num1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Informe o 2º número: ");
            int num2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Informe o 3º número: ");
            int num3 = Int32.Parse(Console.ReadLine());

            int soma = num1 + num2 + num3;

            Console.WriteLine(soma);
        }
    }
}
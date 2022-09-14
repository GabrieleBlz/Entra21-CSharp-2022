using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Crie um código que receba 3 valores e exiba o resultado de um cálculo qualquer entre si

namespace ListaExercicios
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

            Console.WriteLine("Resultado da soma: {0}", soma);
            Console.ReadKey();
            Console.Clear();
        }
    }
}
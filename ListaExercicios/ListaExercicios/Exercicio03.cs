using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Crie um código que calcule a média de 4 notas e imprima APROVADO ou REPROVADO

namespace ListaExercicios
{
    internal class Exercicio03
    {
        public void Executar()
        {
            Console.WriteLine("Informe a sua primeira nota: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a sua segunda nota?: ");
            double nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a sua terceira nota: ");
            double nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a sua quarta nota: ");
            double nota4 = double.Parse(Console.ReadLine());

            double media = (nota1 + nota2 + nota3 + nota4) / 4;

            if (media >= 7)
            {
                Console.WriteLine("Sua média é {0} e você está APROVADO!!", media);
            }
            else if (media < 7)
            {
                Console.WriteLine("Sua média é {0} e você está REPROVADO!!", media);
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}

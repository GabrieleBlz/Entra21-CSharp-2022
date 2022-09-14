using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Crie um código que calcule a raiz quadrada e a raiz cúbica de um número.

namespace ListaExercicios
{
    internal class Exercicio08
    {
        public void Executar()
        {
            Console.WriteLine("Informe o valor: ");
            double valor = double.Parse(Console.ReadLine());
            double raiz = Convert.ToSingle(Math.Sqrt(valor));
            double cubica = Convert.ToSingle(Math.Pow(valor, 1.0 / 3.0));

            Console.WriteLine("Raiz quadrada {0}", raiz);
            Console.WriteLine("Raiz cúbica {0}", cubica);
            Console.ReadKey();
            Console.Clear();
        }
    }
}

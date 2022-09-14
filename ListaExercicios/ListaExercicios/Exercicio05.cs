using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Crie um código que converta o valor de real para dólar

namespace ListaExercicios
{
    internal class Exercicio05
    {
        public void Executar()
        {
            double dolar = 5.25;
            double real;

            Console.WriteLine("Informe quantos reais gostaria de converter: ");
            real = double.Parse(Console.ReadLine());

            double cotacao = real * dolar;

            Console.WriteLine("Valor convertido em doláres é de US{0}", cotacao);
            Console.ReadKey();
            Console.Clear();
        }
    }
}

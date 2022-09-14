using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Calculadora Básica.

namespace ListaExemplosEmSala
{
    internal class Exemplo03
    {
        public void Executar()
        {
            double num1, num2, resultado = 0;
            char operacao;

            Console.WriteLine("Entre com a operação");
            Console.WriteLine("(+) Adição ->");
            Console.WriteLine("(-) Subtração ->");
            Console.WriteLine("(*) Multiplicação ->");
            Console.WriteLine("(/) Divisão ->");
            Console.WriteLine("--------------------------");
            Console.WriteLine();

            Console.WriteLine("Operação: ");

            char.TryParse(Console.ReadLine(), out operacao);

            Console.WriteLine();
            Console.WriteLine("Informe o primeiro valor: ");
            double.TryParse(Console.ReadLine(), out num1);

            Console.WriteLine();
            Console.WriteLine("Informe o segundo valor: ");
            double.TryParse(Console.ReadLine(), out num2);

            Console.WriteLine();
            Console.WriteLine();

            switch(operacao)
            {
                case '+':
                    resultado = Adicao(num1, num2);
                    break;

                case '-':
                    resultado = Subtracao(num1, num2);
                    break;

                case '*':
                    resultado = Multiplicacao(num1, num2);
                    break;

                case '/':
                    resultado = Divisao(num1, num2);
                    break;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(String.Format("Resultado: {0}", resultado));
            Console.ReadKey();
            Console.Clear();
        }
        private static Double Adicao(double num1, double num2)
        {
            return (num1 + num2);
        }
        private static Double Subtracao(double num1, double num2)
        {
            return (num1 - num2);
        }
        private static Double Multiplicacao(double num1, double num2)
        {
            return (num1 * num2);
        }
        private static Double Divisao(double num1, double num2)
        {
            return (num1 / num2);
        }
    }
}

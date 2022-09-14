using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 1º Exemplo: Imprimir se é Par ou Impar. 

namespace ListaExemplosEmSala
{
    internal class Exemplo01
    {
        public void Executar()
        {
            /*  Console.WriteLine("Olá Gabriele!"); // imprime um valor na tela.
                Console.ForegroundColor = ConsoleColor.Blue; // Altera a cor da fonte.
                Console.WriteLine("Meu primeiro projeto. ") 
                Console.ReadKey(); // Aguarda o pressionamento de alguma tecla para continuar. */

            int numeroDigitado;

            Console.WriteLine("Insira um número: "); // Exibe mensagem.
            numeroDigitado = Convert.ToInt32(Console.ReadLine()); // Lê e converte para int o número informado pelo usuário.

            if (numeroDigitado % 2 == 0)
            {
                // Número par.
                Console.WriteLine("Par.");
            }
            else
            {
                // Número Impar.
                Console.WriteLine("Impar.");
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}

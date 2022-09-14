using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Menor de 18 - Acesso NEGADO.

namespace ListaExemplosEmSala
{
    internal class Exemplo04
    {
        public void Executar()
        {
            Processar();
            Console.ReadKey();
        }
        private static void Processar()
        {
            int Idade;

            Console.WriteLine("Informe a sua idade: ");
            int.TryParse(Console.ReadLine(), out Idade);

            if (Idade >= 18)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Acesso permitido.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Acesso Negado.");
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}

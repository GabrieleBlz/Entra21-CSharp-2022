using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Imprima na tela Olá, meu nome é ....

namespace ListaExemplosEmSala
{
    internal class Exemplo05
    {
        public void Executar()
        {
            string Nome;
            Console.WriteLine("Informe o seu nome: ");
            Nome = Console.ReadLine();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine(string.Format("Olá, meu nome é: {0}", Nome));
            Console.ReadKey();
            Console.Clear();
        }
    }
}

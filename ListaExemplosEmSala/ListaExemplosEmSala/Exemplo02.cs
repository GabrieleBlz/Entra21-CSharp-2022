using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 2ºExemplo: Exibir o nome do usuário que for digitar na tela.

namespace ListaExemplosEmSala
{
    internal class Exemplo02
    {
        public void Executar()
        {
            string nome; // Variável que armazena o nome do usuário.

            Console.WriteLine("Informe o seu nome: ");
            nome = Console.ReadLine();

            // Console.WriteLine(string.Format("Meu nome é: {0}", nome));
            // Console.WriteLine("Meu nome é: " + nome);
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Meu nome é: ");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(nome);
            Console.ReadKey();
            Console.Clear();
        }
    }
}

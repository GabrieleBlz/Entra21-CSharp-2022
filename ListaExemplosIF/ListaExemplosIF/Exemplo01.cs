using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Verifica nome e sexo de pessoas.

namespace ListaExemplosIF
{
    internal class Exemplo01
    {
        public void Executar()
        {
            // Declaração de variáveis.
            string nome, // Nome de uma pessoa.
                   sexo; // Sexo de uma pessoa.

            // Solicita e lê os Dados da pessoa.
            Console.WriteLine("Informe o seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine(); // Adiciona uma linha em branco.

            Console.WriteLine("Informe o seu sexo: ");
            sexo = Console.ReadLine();
            Console.WriteLine(); // Adiciona uma linha em branco.

            // Verifica o sexo da pessoa.
            // Estrutura de seleção composta por IF / ELSE.
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Crie um código de cadastro onde tem que aparecer: nome do funcionário, cargo,
    salário base e a idade. */

namespace ListaExercicios
{
    internal class Exercicio07
    {
        public void Executar()
        {
            Console.WriteLine("Informe o nome do funcionário: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe o cargo: ");
            string cargo = Console.ReadLine();

            Console.WriteLine("Informe o salário base: ");
            double salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a idade: ");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("___________________________________");

            Console.WriteLine(@"Nome do funcionário: {0}
Cargo: {1}
Salário base: {2}
Idade: {3}", nome, cargo, salario, idade);

            Console.ReadKey();
            Console.Clear();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Calcule o salário Líquido de um vendedor, sabendo que o seu salário base é de 1800
        e tem um acrescimo de 20% de comissão */

namespace ListaExercicios
{
    internal class Exercicio04
    {
        public void Executar()
        {
            double salarioBase = 1800;
            double acrescimo = salarioBase * 0.2;
            double salarioLiquido = salarioBase + acrescimo;

            Console.WriteLine("Salário Líquido: {0}", salarioLiquido);
            Console.ReadKey();
            Console.Clear();
        }
    }
}

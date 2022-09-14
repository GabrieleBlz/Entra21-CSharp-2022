using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Vários cálculos com notas de 80 alunos
Ler as notas de 80 alunos, armazená-las num array e calcular:
    a média das notas e o número de notas acima da média
    a maior nota e a quantidade de alunos que tiveram a maior nota
    a menor nota e os índices (posição do array) dos alunos que tiveram a maior nota
    o número de alunos com nota negativa (<10)
*/

namespace ListaExemplosArrays
{
    internal class Exemplo11
    {
        public void Executar()
        {
            int[] notas = new int[80];
            int soma = 0;
            int nota = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine("Introduza um valor inteiro de 0 a 20");
                nota = int.Parse(Console.ReadLine());

                if ((nota < 0) || (nota > 20))
                {
                    Console.WriteLine("O valor não está entre 0 a 20.");
                    i--;
                }
                else
                {
                    notas[i] = nota;
                }
            }
            // A média das notas e o número de notas acima da média.
            for (int i = 0; i < notas.Length; i++)
            {
                soma = soma + notas[i];
            }
            double media = soma / 80;
            int conta = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i] > media) conta = conta + 1;
            }
            Console.WriteLine("Contagem de números acima da média " + conta);

            // A maior nota e a quantidade de alunos que tiveram a maior nota.
            int maior = notas[0];
            for (int i = 1; i < notas.Length; i++)
            {
                if (notas[i] > maior) maior = notas[i];
            }
            conta = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i] == maior) conta = conta + 1;
            }
            Console.WriteLine("Contagem de alunos que tiveram a maior nota " + conta);

            // A menor nota e os índices (posição do array) dos alunos que tiveram a menor nota.
            int menor = notas[0];
            for (int i = 1; i < notas.Length; i++)
            {
                if (notas[i] < menor) menor = notas[i];
            }
            Console.WriteLine("A menor nota foi " + menor);
            Console.WriteLine("Os índices dos alunos que tiveram a menor nota são: ");
            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i] == menor) Console.WriteLine("Aluno: " + i);
            }

            // O número de alunos com nota negativa (<10).
            conta = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i] < 10) conta = conta + 1;
            }
            Console.WriteLine("Contagem de alunos que tiveram nota <10: " + conta);
        }
    }
}

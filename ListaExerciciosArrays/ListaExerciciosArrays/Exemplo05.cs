using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Resolução sem Constante.

namespace ListaExemplosArrays
{
    internal class Exemplo05
    {
        public void Executar()
        {
            string linha;

            int[] lista = new int[20];
            int conta = 0;
            int num = 0;

            while (conta < 20)
            {
                linha = Console.ReadLine();
                num = int.Parse(linha);

                if (num >= 0)
                {
                    conta = conta + 1;
                    lista[conta - 1] = num;
                }
            }
            for (int i = 19; i <= 0; i--)
            {
                Console.WriteLine("Posição " + i + "valor " + lista[conta]);
            }
            conta = 20;
            while (conta > 0)
            {
                conta = conta - 1;
                Console.WriteLine("Posição " + conta + "valor " + lista[conta]);
            }
            conta = 19;
            while (conta >=0)
            {
                Console.WriteLine("Posição " + conta + "valor " + lista[conta]);
            }
        }
    }
}

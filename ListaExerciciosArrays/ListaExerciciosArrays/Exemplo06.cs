using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Resolução com Constante.

namespace ListaExemplosArrays
{
    internal class Exemplo06
    {
        public void Executar()
        {
            const int TAM = 20;
            string linha;
            int[] lista = new int[TAM];
            int conta = 0;
            int num = 0;

            while (conta < TAM)
            {
                linha = Console.ReadLine();
                num = int.Parse(linha);

                if (num >= 0)
                {
                    conta = conta + 1;
                    lista[conta - 1] = num;
                }
            }
            for (int i = TAM - 1; i >= 0; i--)
            {
                Console.WriteLine("f> Posição " + i + "valor " + lista[i]);
            }
            conta = TAM;
            while (conta >0)
            {
                conta = conta - 1;
                Console.WriteLine("1> Posição " + conta + "valor " + lista[conta]);
            }
            conta = TAM - 1;
            while (conta >= 0)
            {
                Console.WriteLine("2> Posição " + conta + "valor " + lista[conta]);
                conta = conta - 1;
            }

            // soma todos.
            int soma = 0;
            for (int i = 0; i < TAM; i++)
            {
                soma = soma + lista[i];
            }
            Console.WriteLine("a> Soma " + soma);

            // Soma >= 10.
            soma = 0;
            for (int i = 0; i < TAM; i++)
            {
                if (lista[i] >= 10)
                {
                    soma = soma + lista[i];
                }
            }
            Console.WriteLine("a> Soma " + soma);

            int temp = 0;
            for (int i = 0; i <= (lista.Length/2) - 1; i++)
            {
                temp = lista[i];
                lista[i] = lista[lista.Length - 1 - i];
                lista[lista.Length - 1 - i] = temp;
            }
            for (int i = 0; i < lista.Length; i++)
            {
                Console.WriteLine(lista[i]);
            }
        }
    }
}

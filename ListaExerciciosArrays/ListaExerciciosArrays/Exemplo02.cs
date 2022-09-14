using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExemplosArrays
{
    internal class Exemplo02
    {
        public void Executar()
        {
            // Criando uma ArrayList.
            ArrayList myList = new ArrayList();

            // Adicionando elementos na ArrayList.
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);

            // Exibindo a contagem de elementos da ArrayList.
            Console.WriteLine("Número de elementos: " + myList.Count);

            // Exibindo a capacidade atual da ArrayList.
            Console.WriteLine("Capacidade atual: " + myList.Capacity);
            Console.ReadKey();
            Console.Clear();
        }
    }
}

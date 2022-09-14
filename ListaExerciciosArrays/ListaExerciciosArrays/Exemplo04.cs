using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExemplosArrays
{
    internal class Exemplo04
    {
        public void Executar()
        {
            // Criando ArrayList.
            ArrayList My_array = new ArrayList();

            // Adicionando elementos dentro da ArrayList.
            My_array.Add(1);
            My_array.Add(6);
            My_array.Add(40);
            My_array.Add(10);
            My_array.Add(5);
            My_array.Add(3);
            My_array.Add(2);
            My_array.Add(4);

            // ArrayList antes de classificar.
            Console.WriteLine("ArrayList antes de usar o método Sort(): ");
            foreach (var elements in My_array)
            {
                Console.WriteLine(elements);
            }

            // Ordenando os elementos da ArrayList.
            // Usando o método Sort();
            My_array.Sort();

            // ArrayList após ordenar
            Console.WriteLine("ArrayList após ordenar usando o método Sort(): ");
            foreach (var elements in My_array)
            {
                Console.WriteLine(elements);
            }
            // Aqui não podemos aplicar os métodos como Reverse(), AddRange(), etc.
            // Usando a interface IList.
            IList arrlist1 = new ArrayList();

            // Usando a interface ICollection.
            ICollection arrlist2 = new ArrayList();

            // Usando a interface IEnumerable.
            IEnumerable arrlist3 = new ArrayList();

            Console.ReadKey();
            Console.Clear();
        }
    }
}

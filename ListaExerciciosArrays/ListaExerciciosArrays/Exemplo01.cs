using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExemplosArrays
{
    internal class Exemplo01
    {
        public void Executar()
        {
            // Criando ArrayList.
            ArrayList My_array = new ArrayList();

            // Adicionando elementos.
            // My_array ArrayList - Essa ArrayList contém elementos de tipos diferentes.
            My_array.Add(12.56);
            My_array.Add("GeeksforGeeks");
            My_array.Add(null);
            My_array.Add('G');
            My_array.Add(1234);

            // Acessando os elementos da My_array ArratList.
            // Usando foreach loop.
            foreach (var elements in My_array)
            {
                Console.WriteLine(elements);
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}

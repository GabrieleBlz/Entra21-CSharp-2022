using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExemplosArrays
{
    internal class Exemplo03
    {
        public void Executar()
        {
            // Criando ArrayList.
            ArrayList My_array = new ArrayList();

            // Adicionando elementos dentro da My_array ArrayList.
            My_array.Add('G');
            My_array.Add('E');
            My_array.Add('E');
            My_array.Add('K');
            My_array.Add('S');
            My_array.Add('F');
            My_array.Add('O');
            My_array.Add('R');
            My_array.Add('G');
            My_array.Add('E');
            My_array.Add('E');
            My_array.Add('K');
            My_array.Add('S');

            Console.WriteLine("Número inicial de elementos: " + My_array.Count);

            // Usando o método Remove()
            My_array.Remove('G');
            Console.WriteLine("Após o método Remove() o" + "número de elementos: " + My_array.Count);

            // Remove o elemento presente no índice 8.
            // Usando o método RemoveAt().
            My_array.RemoveAt(8);
            Console.WriteLine("Após o método RemoveAt() o " + "número de elementos: " + My_array.Count);

            // Remove 3 elementos a partir do índice 1.
            // Usando o método RemoveRange().
            My_array.RemoveRange(1, 3);
            Console.WriteLine("Após o método RemoveRange() o " + "número de elementos: " + My_array.Count);

            // Remove todos os elementos presente na ArrayList.
            // Usando o método Clear().
            My_array.Clear();
            Console.WriteLine("Após o método Clear() o " + "número de elementos: " + My_array.Count);
            Console.ReadLine();
            Console.Clear();
        }
    }
}

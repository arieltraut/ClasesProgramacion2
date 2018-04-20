using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Ej_27
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomNumber = new Random();
            List<int> listaNumeros = new List<int>();
            Queue<int> colaNegativos = new Queue<int>(); 

            for (int i = 0; i < 20; i++)  //List.
            {
                int numero = randomNumber.Next(-100, 100);
                if (numero != 0)
                    listaNumeros.Add(numero);
                else
                    i--;
            } 
           
            foreach (int a in listaNumeros)
            {
                Console.WriteLine(a);
                colaNegativos.Enqueue(a);
            }

            

            listaNumeros.Sort(ordenDescendente) ;
            Console.WriteLine();
            foreach (int a in listaNumeros)
            {
                Console.WriteLine(a);
            }

            Console.ReadKey();

        }


        static int ordenDescendente (int a, int b) //siempre static
        {
            return -(a.CompareTo(b));  
        }

    }
}

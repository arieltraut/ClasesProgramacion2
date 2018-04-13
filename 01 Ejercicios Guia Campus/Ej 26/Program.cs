using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_26
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[20];
            Random randomNumber = new Random();
            
            for(int i=0;i<20;i++)
            {
                int numero = randomNumber.Next(-100, 100);
                if (numero != 0)
                {
                    numeros.SetValue(numero,i);
                    Console.WriteLine(numeros.GetValue(i));
                }
                else
                    i--;                  
            }
            Console.WriteLine("***********POSITIVOS ORDENADOS***************");
            Array.Sort(numeros);
            Array.Reverse(numeros);
            foreach (int a in numeros)
            {
                if (a>=0)
                    Console.WriteLine(a);
            }
            Console.WriteLine("***********NEGATIVOS ORDENADOS***************");
            int[] numerosNegativos = numeros.Where(i => i< 0).ToArray();
            Array.Sort(numerosNegativos);

            foreach (int a in numerosNegativos)
            {
                Console.WriteLine(a);
            }            


            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, j, numeroHasta = 0; //flagEsPrimo;

            Console.WriteLine("Ingrese un numero");
            if (int.TryParse(Console.ReadLine(), out numeroHasta)) //preguntar si es true o false
            {
                for (i = 2; i <= numeroHasta; i++)
                {
                    //flagEsPrimo = 1;
                    for (j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                            //flagEsPrimo = 0;
                            break;
                    }
                    if (i == j)
                    {
                        Console.WriteLine(i);

                    }
                }
                Console.ReadKey();
            }
        }
    }
}


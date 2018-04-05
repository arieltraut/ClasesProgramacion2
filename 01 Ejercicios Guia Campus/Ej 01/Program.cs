using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,aux=0,max=0,min=0,acum=0;
            float prom;

            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un numero");
                if (int.TryParse(Console.ReadLine(), out aux)) //preguntar si es true o false
                {
                    acum += aux;
                    if (i == 0)
                    {
                        max = aux;
                        min = aux;
                        prom = aux;
                    }
                    else
                    {
                        if (aux > max)
                        {
                            max = aux;
                        }
                        if (aux < min)
                        {
                            min = aux;
                        }
                    }
                }
           }
            Console.WriteLine("El numero maximo es {0}",max);
            Console.WriteLine("El numero minimo es {0}", min);
            Console.WriteLine("El promedio es {0}", acum/i);
            Console.ReadKey();

        }
    }
}

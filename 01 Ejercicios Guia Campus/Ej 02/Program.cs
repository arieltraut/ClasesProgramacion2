using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_02
{
    class Program
    {
        static void Main(string[] args)
        {
            double aux = 0, cuadrado = 0, cubo = 0;

            Console.WriteLine("Ingrese un numero");
            if (double.TryParse(Console.ReadLine(), out aux)) //preguntar si es true o false
            {
                if (aux > 0)
                {
                    cuadrado = Math.Pow(aux, 2);
                    cubo = Math.Pow(aux, 3);
                    Console.WriteLine("El cuadrado es {0}", cuadrado);
                    Console.WriteLine("El cubo es {0}", cubo);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("ERROR. ¡Reingresar número!");
                }
            }

        }
    }
}

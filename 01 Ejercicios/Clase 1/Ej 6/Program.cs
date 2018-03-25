using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int añoIngresado;
            bool esBisiesto = false;

            Console.WriteLine("Ingrese un numero");
            if (int.TryParse(Console.ReadLine(), out añoIngresado)) //preguntar si es true o false
            {
                if(añoIngresado % 4 == 0)
                {
                    esBisiesto = true;
                    if(añoIngresado % 100 == 0 && añoIngresado % 400 != 0)
                    {
                        esBisiesto = false;    
                    }
                }
            }
            if(esBisiesto)
                Console.WriteLine("El año {0} es bisiesto", añoIngresado);
            else
                Console.WriteLine("El año {0} no es bisiesto", añoIngresado);
            
            Console.ReadKey();
        }
    }
}

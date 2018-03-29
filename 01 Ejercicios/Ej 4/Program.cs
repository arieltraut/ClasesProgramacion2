using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=1,descedente,ascendente, numeroHasta, acumuladorIzq=0, acumuladorDer=0;

            Console.WriteLine("Ingrese un numero");
            if (int.TryParse(Console.ReadLine(), out numeroHasta)) //preguntar si es true o false
            {
                for (; i <= numeroHasta; i++)
                {
                    descedente=i-1;
                    ascendente=i+1;
                    do
                    {
                        acumuladorIzq += descedente;
                        descedente--;

                    }while(descedente>0);
                    
                    do
                    {
                        acumuladorDer += ascendente;
                        ascendente++;
                    }while(acumuladorDer < acumuladorIzq);

                    if (acumuladorIzq == acumuladorDer)
                    {
                        Console.WriteLine("El numero {0} es un centro numerico entre 1 y {1}",i,numeroHasta);
                    }
                    acumuladorIzq = 0;
                    acumuladorDer = 0;
                }
                Console.ReadKey();
            }
        }
    }
}

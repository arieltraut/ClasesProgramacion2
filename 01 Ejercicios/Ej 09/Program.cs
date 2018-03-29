using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_09
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, altura;
            string imprimir = "*";
            //string incremento = "**";

            Console.WriteLine("Ingrese un numero");
            if (int.TryParse(Console.ReadLine(), out altura)) //preguntar si es true o false
            {
                for (i = 0; i < altura; i++)
                {
                    Console.WriteLine(imprimir);
                    imprimir += "**";
                }
            }
            Console.ReadKey();
        }
    }
}

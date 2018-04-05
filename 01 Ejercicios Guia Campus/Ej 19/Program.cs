using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador numero = new Sumador();

            Sumador numero2 = new Sumador(6);


            numero.Sumar(2, 2);

            Console.WriteLine("numero uno : {0}, y numero dos es {1}", numero.CantidadSumas, numero2.CantidadSumas);
            
            
            
            
            Console.ReadKey();

        }
    }
}

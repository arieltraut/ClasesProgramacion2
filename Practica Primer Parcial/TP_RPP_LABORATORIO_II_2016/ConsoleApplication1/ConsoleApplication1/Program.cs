using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dias dia = Dias.Lunes;
            Dias dia2 = Dias.Jueves;

            Console.WriteLine(dia);
            Console.WriteLine((int)dia);
            Console.WriteLine(dia2);
            Console.WriteLine((int)dia2);
            Console.ReadKey();




        }


            public enum Dias
            {
                Lunes,
                Martes,
                Miercoles = 10,
                Jueves,
                Viernes
            }

        
    }
}

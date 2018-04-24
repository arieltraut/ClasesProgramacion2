using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_33
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro dune = new Libro();

            dune[0] = "primer pagina";
            dune[1] = "segunda pagina";


            Console.WriteLine("{0}", dune[0]);
            Console.WriteLine("{0}", dune[1]);
            Console.ReadKey();
        }
    }
}

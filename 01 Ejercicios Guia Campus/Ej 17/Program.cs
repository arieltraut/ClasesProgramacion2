using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Boligrafo boligrafoAzul = new Boligrafo();
            Boligrafo boligrafoRojo = new Boligrafo();

            boligrafoAzul.SetColor(ConsoleColor.Blue);
            boligrafoRojo.SetColor(ConsoleColor.Red);

            boligrafoAzul.SetTinta(100);
            boligrafoRojo.SetTinta(50);

            
        }
    }
}

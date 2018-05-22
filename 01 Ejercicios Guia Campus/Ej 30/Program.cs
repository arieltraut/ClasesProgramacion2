using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_30
{
    class Program
    {
        static void Main(string[] args)
        {
            Competencia competencia = new Competencia(10,5);

            AutoF1 primerAuto = new AutoF1(1, "McLaren");
            AutoF1 segundoAuto = new AutoF1(1, "Ferrari");
            AutoF1 tercerAuto = new AutoF1(1, "Mercedes");
            AutoF1 cuartoAuto = new AutoF1(1, "Williams");
            AutoF1 quintoAuto = new AutoF1(1, "Renault");
            AutoF1 sextoAuto = new AutoF1(1, "Haas");


            Console.WriteLine((competencia + primerAuto).ToString());
            Console.WriteLine((competencia + segundoAuto).ToString());
            Console.WriteLine((competencia + tercerAuto).ToString());
            Console.WriteLine((competencia + cuartoAuto).ToString());
            Console.WriteLine((competencia + quintoAuto).ToString());
            Console.WriteLine((competencia + sextoAuto).ToString());


            Console.WriteLine(competencia.Mostrar());

            Console.ReadKey();

        }
    }
}

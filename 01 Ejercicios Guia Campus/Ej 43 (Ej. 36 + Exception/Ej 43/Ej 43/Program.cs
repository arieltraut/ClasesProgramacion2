using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_43
{
    class Program
    {
        static void Main(string[] args)
        {
            Competencia competencia = new Competencia(10, 5, Competencia.TipoCompetencia.MotoCross);

            AutoF1 primerAuto = new AutoF1(1, "McLaren");
            AutoF1 segundoAuto = new AutoF1(1, "Ferrari");
            AutoF1 tercerAuto = new AutoF1(1, "Mercedes");
            AutoF1 cuartoAuto = new AutoF1(1, "Williams");
            AutoF1 quintoAuto = new AutoF1(1, "Renault");
            AutoF1 sextoAuto = new AutoF1(1, "Haas");
            MotoCross primerMoto = new MotoCross(1, "Kawasaki");

            Console.WriteLine("Cargado? " + ((competencia + primerAuto) ? "Si" : "No"));
            Console.WriteLine("Cargado? " + ((competencia + segundoAuto) ? "Si" : "No"));
            Console.WriteLine("Cargado? " + ((competencia + segundoAuto) ? "Si" : "No"));
            Console.WriteLine("Cargado? " + ((competencia + tercerAuto) ? "Si" : "No"));
            Console.WriteLine("Cargado? " + ((competencia + cuartoAuto) ? "Si" : "No"));
            Console.WriteLine("Cargado? " + ((competencia + quintoAuto) ? "Si" : "No"));
            Console.WriteLine("Cargado? " + ((competencia + sextoAuto) ? "Si" : "No"));
            Console.WriteLine("Cargado? " + ((competencia + primerMoto) ? "Si" : "No"));



            Console.WriteLine("\n" + competencia.Mostrar());

            Console.ReadKey();
        }
    }
}

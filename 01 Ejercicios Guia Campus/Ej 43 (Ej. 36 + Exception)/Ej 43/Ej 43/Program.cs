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
            Competencia competencia = new Competencia(10, 5, Competencia.TipoCompetencia.F1);

            AutoF1 primerAuto = new AutoF1(1, "McLaren");
            AutoF1 segundoAuto = new AutoF1(1, "Ferrari");
            AutoF1 tercerAuto = new AutoF1(1, "Mercedes");
            AutoF1 cuartoAuto = new AutoF1(1, "Williams");
            AutoF1 quintoAuto = new AutoF1(1, "Renault");
            AutoF1 sextoAuto = new AutoF1(1, "Haas");
            MotoCross primerMoto = new MotoCross(1, "Kawasaki");

            try
            {
                Console.WriteLine("Cargado? " + ((competencia + primerAuto) ? "Si" : "No"));
                Console.WriteLine("Cargado? " + ((competencia + segundoAuto) ? "Si" : "No")); //auto repetido, no se carga
                Console.WriteLine("Cargado? " + ((competencia + segundoAuto) ? "Si" : "No"));
                Console.WriteLine("Cargado? " + ((competencia + tercerAuto) ? "Si" : "No"));
                Console.WriteLine("Cargado? " + ((competencia + cuartoAuto) ? "Si" : "No"));
                Console.WriteLine("Cargado? " + ((competencia + quintoAuto) ? "Si" : "No"));
                Console.WriteLine("Cargado? " + ((competencia + sextoAuto) ? "Si" : "No"));  //torneo lleno, no se carga
                Console.WriteLine("Cargado? " + ((competencia + primerMoto) ? "Si" : "No")); //no es F1, no se carga, tira exception
            }
            catch (CompetenciaNoDisponibleException e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine("\n" + competencia.Mostrar());

            Console.ReadKey();
        }
    }
}

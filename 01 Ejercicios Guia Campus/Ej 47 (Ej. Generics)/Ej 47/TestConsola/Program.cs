using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace TestConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Torneo<Equipo> torneoFutbol = new Torneo<Equipo>("Torneo Apertura");
            Torneo<Equipo> torneoBasquet = new Torneo<Equipo>("NBA Playoffs");

            EquipoFutbol boca = new EquipoFutbol("Boca",DateTime.Now);
            EquipoFutbol river = new EquipoFutbol("River", DateTime.Now);
            EquipoFutbol velez = new EquipoFutbol("Velez", DateTime.Now);

            EquipoBasquet lakers = new EquipoBasquet("Lakers", DateTime.Now);
            EquipoBasquet bulls = new EquipoBasquet("Bulls", DateTime.Now);
            EquipoBasquet heat = new EquipoBasquet("Heat", DateTime.Now);

            torneoFutbol += boca;
            torneoFutbol += river;
            torneoFutbol += velez;
            torneoBasquet += lakers;
            torneoBasquet += bulls;
            torneoBasquet += heat;

            Console.WriteLine(torneoFutbol.Mostrar());
            Console.WriteLine();
            Console.WriteLine(torneoBasquet.Mostrar());

            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.WriteLine(torneoFutbol.JugarPartido);

            Console.WriteLine("-------------------------");

            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.WriteLine(torneoBasquet.JugarPartido);

            Console.ReadKey();

 
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_29
{
    class Program
    {
        static void Main(string[] args)
        {
            Equipo boca = new Equipo(22,"Boca Juniors");

            Jugador ariel = new Jugador(30859667, "Ariel");
            Jugador kero = new Jugador(30666777, "Kero",10,15);

            Console.WriteLine(ariel.MostrarDatos());
            Console.WriteLine(kero.MostrarDatos());



            bool cargaOk;
            cargaOk = boca + ariel;
            Console.WriteLine(cargaOk.ToString());
            cargaOk = boca + kero;
            Console.WriteLine(cargaOk.ToString());
            cargaOk = boca + ariel;
            Console.WriteLine(cargaOk.ToString());

            Console.ReadKey();


        }
    }
}

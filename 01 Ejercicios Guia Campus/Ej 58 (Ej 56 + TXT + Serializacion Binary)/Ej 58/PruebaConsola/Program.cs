using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IO;

namespace PruebaConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[1] Abrir\n[2] Guardar");
            string ruta = @"D:\";

            switch (Int32.Parse(Console.ReadLine()))
            {
                case 1:
           
                    PuntoDat leerDat = new PuntoDat();
                    leerDat = leerDat.Leer(ruta);
                    Console.WriteLine(leerDat.Contenido);
                    break;
                case 2:                 
                    PuntoDat guardarDat = new PuntoDat();
                    guardarDat.Contenido = "xxx";
                    bool aux2 = guardarDat.Guardar(ruta, guardarDat);

                    Console.WriteLine("Guardado!");
                    break;
            }
            Console.ReadKey();
        }
    }
}

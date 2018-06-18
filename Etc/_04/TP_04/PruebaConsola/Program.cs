using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace PruebaConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prueba extension
            string a = "Texto a guardar";
            a.Guardar(@"d:\");  //extension de la clase String

        }
    }
}
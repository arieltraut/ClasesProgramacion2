using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ej_50
{
    class Program
    {
        static void Main(string[] args)
        {
            GuardarTexto<int, String> texto = new GuardarTexto<int, string>();
            Serializar<int, String> objeto = new Serializar<int, string>();

            Console.WriteLine(texto.Guardar(1));
            Console.WriteLine(texto.Leer());
            Console.WriteLine();
            Console.WriteLine(objeto.Guardar(1));
            Console.WriteLine(objeto.Leer());

            Console.ReadKey();
        }
    }
}

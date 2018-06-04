using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona("Clark", "Kent");
            Persona.Guardar(persona);

            Persona persona2 = Persona.Cargar();
            Console.WriteLine(persona2.ToString());
            Console.ReadKey();

        }
    }
}

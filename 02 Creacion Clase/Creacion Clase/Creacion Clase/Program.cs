using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creacion_Clase
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion, binario;
            Conversor conversor = new Conversor();


            Console.WriteLine("1- Convertir de Binario a Entero");
            Console.WriteLine("2- Convertir de Entero a Binario");
            Console.WriteLine("3- Salir");

            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingresar Binario a convertir");
                        if (int.TryParse(Console.ReadLine(), out binario))
                        {
                            conversor.EnteroBinario(binario);
                        }

                        break;
                    case 2:
                        break;
                    case 3:
                        break;

                }
            }
        }
    }
}

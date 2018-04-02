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
            int opcion, enteroIngresado;
            string binarioIngresado;
            Conversor conversor = new Conversor();
            
            do
            {
                Console.WriteLine("1- Convertir de Binario a Entero");
                Console.WriteLine("2- Convertir de Entero a Binario");
                Console.WriteLine("3- Salir");

                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Ingrese Binario a convertir");
                            binarioIngresado = Console.ReadLine();
                            Console.WriteLine(conversor.BinarioDecimal(binarioIngresado));
                            break;
                        case 2:                           
                            Console.WriteLine("Ingresar Entero a convertir");
                            if (int.TryParse(Console.ReadLine(), out enteroIngresado))
                            {
                                Console.WriteLine(conversor.EnteroBinario(enteroIngresado));
                            }
                            break;
                        case 3:
                            break;
                    }
                    Console.ReadKey();
                    Console.Clear();
                }
            }while(opcion != 3);
         }
    }
}

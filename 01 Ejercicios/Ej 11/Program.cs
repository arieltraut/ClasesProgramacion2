using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,numeroIngresado, valorMaximo=0, valorMinimo=0, promedio=0, acumulador=0;

            for (i = 0; i < 10; i++)
            {
               Console.WriteLine("Ingresar 10 numeros entre -100 y 100");
               
                if (int.TryParse(Console.ReadLine(), out numeroIngresado))
                {
                    if (Validacion.Validar(numeroIngresado, -100, 100))
                    {
                        acumulador += numeroIngresado;
                        if (i == 0)
                        {
                            valorMaximo = numeroIngresado;
                            valorMinimo = numeroIngresado;
                            promedio = numeroIngresado;
                        }
                        else
                        {
                            if (numeroIngresado > valorMaximo)
                            {
                                valorMaximo = numeroIngresado;
                            }
                            if (numeroIngresado < valorMinimo)
                            {
                                valorMinimo = numeroIngresado;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Valor incorrecto, ingrese nuevamente");
                        i--;
                    }
                }
            }
            promedio = acumulador / 10;
            Console.WriteLine("El numero maximo es {0}",valorMaximo);
            Console.WriteLine("El numero minimo es {0}", valorMinimo);
            Console.WriteLine("El promedio es {0}", promedio);
            Console.ReadKey();
        }
    }
}

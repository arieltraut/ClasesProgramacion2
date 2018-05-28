using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej._42
{
    class Program
    {
        static void Main(string[] args)
        {
            float numero1 = 7;
            float numero2 = 0;
            float resultado;
            try
            {
                resultado = Dividir(numero1, numero2);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }


        public static float Dividir(float num1, float num2)
        {
            if (num2 != 0)
                return num1 / num2;
            else
                throw new DivideByZeroException("El divisor no puede ser cero");
        }

        //        public Excepcion(string message, Exception innerException)
        //    : base(message, innerException)
        //{

        //}
    }
}

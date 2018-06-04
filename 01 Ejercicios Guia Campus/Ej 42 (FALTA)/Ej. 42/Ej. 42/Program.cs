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
            //try
            //{
                resultado = Dividir(numero1, numero2);
            //}
            //catch (DivideByZeroException e)
            //{
            //    Console.WriteLine(e.Message);               
            //    throw new UnaException(e.Message, e);
            //}

            Console.ReadKey();
        }


        public static float Dividir(float num1, float num2)
        {
            float resultado = 0;
            if (num2 == 0)
                throw new DivideByZeroException("El divisor no puede ser cero");            
            
            try
            {
                resultado = num1 / num2;
            }
            catch (DivideByZeroException e)
            {
                //Console.WriteLine(e.Message);
                throw new UnaException(e.Message, e);
            }

            return resultado;
            

        }
    }
}

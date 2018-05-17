using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_42
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public static float Dividir(float num1, float num2)
        {
            if (num2 != 0)
                return num1 / num2;
            else
                throw Excepcion();
        }
    }
}

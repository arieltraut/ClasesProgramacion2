using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creacion_Clase
{
    class Conversor
    {
        public string EnteroBinario(int a)
        {
            int resto;
            int resultado = a;
            string retorno = null;
            while (resultado >= 2)
            {
                resto = resultado % 2;
                resultado /= 2;
                retorno = string.Concat(retorno, resto);
            }
            retorno = string.Concat(retorno, resultado);
            return retorno;
        }

        public int BinarioEntero(string a)
        {
            int i;
            int retorno=0;
            for (i = 0; i < a.Length; i++)
            {
                byte digitos = byte.Parse(a.Substring(i, 1));
                if (digitos == 1)
                    retorno += (int)Math.Pow(2,i);              
            }
            return retorno;
        }

        public double BinarioDecimal(string numero)
        {
            int bl = numero.Length;
            double Decimal = 0;

            for (int i = 1; i <= bl; i++)
            {
                byte n = byte.Parse(numero.Substring(bl - i, 1));
                if (n == 1)
                    Decimal += System.Math.Pow(2, i - 1);
            }
            return Decimal;
        }
    }

}

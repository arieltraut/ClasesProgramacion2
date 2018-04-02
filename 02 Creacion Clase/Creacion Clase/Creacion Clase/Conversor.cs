using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creacion_Clase
{
    class Conversor
    {
        public double BinarioDecimal(string numero)
        {
            double nroDecimal = 0;

            for (int i = 0; i < numero.Length; i++)
            {
                nroDecimal += double.Parse(numero[i].ToString()) * (double)Math.Pow(2, i);
            }
            return nroDecimal;
        }        
        
        public string EnteroBinario(int a)
        {
            int resto;
            int resultado = a;
            string retorno = "";
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


    }

}

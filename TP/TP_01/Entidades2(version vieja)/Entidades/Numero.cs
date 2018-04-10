using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Numero
    {
        private double numero;

        /// <summary>
        /// Método que valida valores numericos.
        /// </summary>
        /// <param name="strNumero">Cadena a validar</param>
        /// <returns>Valor ingresado en formato double</returns>
        private double ValidarNumero(string strNumero) //ver private
        {
            double retorno;
            if (double.TryParse(strNumero, out retorno))
                return retorno;
            else
                return 0;
        }

        /// <summary>
        /// Propiedad que valida y asigna valor al atributo numero.
        /// </summary>
        /// <returns>Valor ingresado en formato double</returns>
        public double SetNumero
        {
            set
            {
                if (ValidarNumero(Convert.ToString(value)) != 0)
                    this.numero = value;
            }
        }

        /// <summary>
        /// Método que convierte un binario ASCII en un número entero
        /// </summary>
        /// <param name="binario">Binario ASCII a convertir. EJ: 1001</param>
        /// <returns>Valor entero resultado de la conversión. EJ: 9</returns>
        public string BinarioDecimal(string binario)
        {
            double nroDecimal = 0;
            string error = "Valor invalido";

            for (int i = 0; i < binario.Length; i++)
            {
                if (binario[i] == 1 || binario[i] == 0)
                    nroDecimal += double.Parse(binario[i].ToString()) * (double)Math.Pow(2, i);
                else
                    return error;
            }
            return nroDecimal.ToString();
        }

        /// <summary>
        /// Método que convierte un número entero en un binario ASCII
        /// </summary>
        /// <param name="numero">Número a convertir. EJ: 9</param>
        /// <returns>Valor binario ASCII resultado de la conversión. EJ: 1001</returns>
        public static string DecimalBinario(double numero)
        {
            string binario = "";
            while (numero > 0)
            {
                binario = (numero % 2).ToString() + binario;
                numero = numero / 2;
            }
            return binario;
        }

        /// <summary>
        /// Método que convierte un string entero en un binario ASCII
        /// </summary>
        /// <param name="numero">Número a convertir. EJ: 9</param>
        /// <returns>Valor binario ASCII resultado de la conversión. EJ: 1001</returns>
        public static string DecimalBinario(string numero)
        {
            string binario = "", error = "Valor invalido";
            double conversion = 0;
            if (double.TryParse(numero, out conversion))
            {
                while (conversion > 0)
                {
                    binario = (conversion % 2).ToString() + binario;
                    conversion = conversion / 2;
                }
            }
            else
                return error;
            return binario;
        }
    }
}

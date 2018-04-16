using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double numero;

        #region Constructores (ver)

        public Numero(double numero)
        {
            this.SetNumero = numero;
        }

        public Numero(string strNumero)
        {
            double conversion;
            if (double.TryParse(strNumero, out conversion))
                this.numero = conversion;
        }
        #endregion
        
        #region Set

        /// <summary>
        /// Método que valida valores numericos.
        /// </summary>
        /// <param name="strNumero">Cadena a validar</param>
        /// <returns>Valor ingresado en formato double</returns>
        private double ValidarNumero(string strNumero) //ver private
        {
            double retorno=0;
            if (double.TryParse(strNumero, out retorno))
                return retorno;
            return retorno;
        }

        /// <summary>
        /// Propiedad que valida y asigna valor al atributo numero.
        /// </summary>
        /// <returns>Valor ingresado en formato double</returns>
        public double SetNumero
        {
            set
            {
                if (ValidarNumero(Convert.ToString(value)) != 0)  //ValidarNumero(value) != 0 recibe string directo del texbox
                    this.numero = value;
            }
        }

        #endregion

        #region Conversiones Decimal/Binario

        /// <summary>
        /// Método que convierte un binario ASCII en un número entero
        /// </summary>
        /// <param name="binario">Binario ASCII a convertir. EJ: 1001</param>
        /// <returns>Valor entero resultado de la conversión. EJ: 9</returns>
        public static string BinarioDecimal(string binario)
        {
            int nroDecimal = 0, aux = 0;
            string retorno = "";

            for (int i = 1; i <= binario.Length; i++)
            {
                if (Int32.TryParse(binario[i-1].ToString(), out aux) && (aux == 1 || aux == 0))
                {
                    nroDecimal += aux * (int)Math.Pow(2, binario.Length - i);
                    retorno = nroDecimal.ToString();
                }
                else
                    retorno = "Valor invalido";
            }
            return retorno;
        }

        /// <summary>
        /// Método que convierte un número entero en un binario ASCII
        /// </summary>
        /// <param name="numero">Número a convertir. EJ: 9</param>
        /// <returns>Valor binario ASCII resultado de la conversión. EJ: 1001</returns>
        public static string DecimalBinario(double numero)
        {
            string binario = "";
            while (numero >= 2)
            {
                binario = (numero % 2).ToString() + binario;
                numero = (int)numero / 2;
            }
            return numero.ToString()+binario;
        }

        /// <summary>
        /// Método que convierte un string entero en un binario ASCII
        /// </summary>
        /// <param name="numero">Número a convertir. EJ: 9</param>
        /// <returns>Valor binario ASCII resultado de la conversión. EJ: 1001</returns>
        public static string DecimalBinario(string numero)
        {
            string error = "Valor invalido";
            for (int i = 0; i < numero.Length; i++)
            {
                if (!char.IsDigit(numero, i))
                    return error;
            }
            return DecimalBinario(double.Parse(numero));
        }

        #endregion

        #region Sobrecargas
        /// <summary>
        /// Método que sobrecarga el operador +
        /// </summary>
        /// <param name="............">...............</param>
        /// <returns>......................</returns>
        public static double operator +(Numero n1, Numero n2)
        {
            double retorno = n1.numero + n2.numero;
            return retorno;
        }

        /// <summary>
        /// Método que sobrecarga el operador -
        /// </summary>
        /// <param name="............">...............</param>
        /// <returns>......................</returns>
        public static double operator -(Numero n1, Numero n2)
        {
            double retorno = n1.numero - n2.numero;
            return retorno;
        }

        /// <summary>
        /// Método que sobrecarga el operador *
        /// </summary>
        /// <param name="............">...............</param>
        /// <returns>......................</returns>
        public static double operator *(Numero n1, Numero n2)
        {
            double retorno = n1.numero * n2.numero;
            return retorno;
        }

        /// <summary>
        /// Método que sobrecarga el operador /
        /// </summary>
        /// <param name="............">...............</param>
        /// <returns>......................</returns>
        public static double operator /(Numero n1, Numero n2)
        {
            double retorno = n1.numero / n2.numero;
            return retorno;
        }
        #endregion
    }
}

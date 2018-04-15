using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        /// <summary>
        /// Método que valida operadores aritmericos.
        /// </summary>
        /// <param name="operador">Cadena a validar</param>
        /// <returns>Cadena validada</returns>
        private static string ValidarOperador(string operador)
        {
            if (operador != "-" && operador != "/" && operador != "*")
                return "+";
            return operador;
        }

        /// <summary>
        /// ........................
        /// </summary>
        /// <param name="...">.........</param>
        /// <returns>..................</returns>
        public static double Operar(Numero num1, Numero num2, string operador) //ver tema static
        {
            double resultado = 0;
            switch (operador) //ValidarOperador(operador)
            {
                case "+":
                    resultado = num1 + num2;
                    break;
                case "-":
                    resultado = num1 - num2;
                    break;
                case "/":
                    resultado = num1 / num2;
                    break;
                case "*":
                    resultado = num1 * num2;
                    break;
            }
            return resultado;
        }
    }
}

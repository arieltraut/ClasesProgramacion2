using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;


namespace MiCalculadora
{
    class LaCalculadora
    {
        Button btnCerrar;
        Button btnConvertirABinario;
        Button btnConvertirADecimal;
        Button btnLimpiar;
        Button btnOperar;
        ComboBox cmbOperador;
        IContainerControl components;
        Label lblResultado;
        TextBox txtNumero1;
        TextBox txtNumero2;

        public static double Operar(string numero1, string numero2, string operador) // ver porque dice private
        {
            Numero num1 = new Numero(numero1);
            Numero num2 = new Numero(numero2);

            return  Calculadora.Operar(num1,num2,operador);
        }
    }
}

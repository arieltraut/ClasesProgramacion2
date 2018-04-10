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

        private static double Operar(string numero1, string numero2, string operador)
        {
            
            Calculadora.Operar((Numero)numero1 

            return 0;
        }
    }
}

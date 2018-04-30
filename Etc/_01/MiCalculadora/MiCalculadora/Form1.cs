using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class LaCalculadora : Form
    {
        public LaCalculadora()
        {
            InitializeComponent();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            int indice = cmbOperador.SelectedIndex;
            if (indice != -1)
            {
                double aux=0;
                txtNumero1.Text = (Double.TryParse(txtNumero1.Text, out aux)) ? txtNumero1.Text : "0";                
                txtNumero2.Text = (Double.TryParse(txtNumero2.Text, out aux)) ? txtNumero2.Text : "0";                               
                
                if (indice == 3 && txtNumero2.Text == "0") 
                    lblResultado.Text = "No se puede dividir en cero";
                else
                    lblResultado.Text = (this.Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Items[indice].ToString())).ToString("0.##");
            }
        }
            
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            cmbOperador.Text = "";
            lblResultado.Text = "";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            if(lblResultado.Text != "")
                lblResultado.Text = Numero.DecimalBinario(lblResultado.Text);        
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text != "")            
                lblResultado.Text = Numero.BinarioDecimal(lblResultado.Text);        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblResultado.Text = "";
        }

        private void cmbOperador_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtNumero1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void txtNumero2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        /// <summary>
        /// Método que toma ambos operandos y operador y retorna el resultado
        /// </summary>
        /// <param name="numero1">Primer operando.</param>
        /// <param name="numero2">Segundo operando</param>
        /// <param name="operador">Operador</param>
        /// <returns>Resultado de la operacion</returns>
        private double Operar(string numero1, string numero2, string operador)
        {
            Numero num1 = new Numero(numero1);
            Numero num2 = new Numero(numero2);
            double resultado = Calculadora.Operar(num1, num2, operador);
            return resultado;
        }
    }
}


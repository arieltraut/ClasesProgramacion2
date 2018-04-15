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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            int indice = cmbOperador.SelectedIndex;
            if (indice != -1)
                if (indice == 3 && (String.IsNullOrEmpty(txtNumero2.Text) || indice == 3 && (Convert.ToDouble(txtNumero2.Text)) == 0))
                    lblResultado.Text = "No se puede dividir en cero";
                else
                    lblResultado.Text = (LaCalculadora.Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Items[indice].ToString())).ToString("0.##");       
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
    }
}

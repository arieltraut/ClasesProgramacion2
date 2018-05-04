﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaHerencia;

namespace CentralTelefonicaForm
{
    public partial class LlamadorForm : Form
    {
        private Centralita c;

        public LlamadorForm()
        {
            InitializeComponent();
        }

        private void LlamadorForm_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            cmbFranja.DataSource = Enum.GetValues(typeof(CentralitaHerencia.Provincial.Franja));
        }


        #region botones numeros
        private void button1_Click(object sender, EventArgs e)
        {
                txtNroDestino.Text += 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += 9;
        }

        private void buttonPunto_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += ".";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += 0;
        }

        private void buttonNumeral_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "#";
        }
        #endregion

        private void buttonLlamar_Click(object sender, EventArgs e)
        {
            if (txtNroDestino.Text[0] == '#')
            {
                Provincial.Franja franjas;
                Enum.TryParse<CentralitaHerencia.Provincial.Franja>(cmbFranja.SelectedValue.ToString(), out franjas);
                Provincial llamadaProvincial = new Provincial(txtNroOrigen.Text, Provincial.Franja.Franja_1, 21, txtNroDestino.Text);
                //c + llamadaProvincial;
            }
            else
            {
                Local llamadaLocal = new Local("Bernal", 30, "Rosario", 2.65f);
                //c + llamadaLocal;
            }           
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void cmbFranja_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lectura
            Provincial.Franja franjas;
            Enum.TryParse<CentralitaHerencia.Provincial.Franja>(cmbFranja.SelectedValue.ToString(), out franjas);
        }






        private void txtNroDestino_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtNroDestino_TextChanged(object sender, EventArgs e)
        {

        }      

    }
}
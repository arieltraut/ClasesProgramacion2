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
using Interfaces;

namespace FormHilos
{
    public partial class fmrPpal : Form
    {
        private LosHilos hilos;
        
        public fmrPpal()
        {
            InitializeComponent();
            hilos = new LosHilos();
            hilos.AvisoFin += MostrarMensajeFin;
        }

        private void btnLanzar_Click(object sender, EventArgs e)
        {
            try
            {
                hilos += 1;
            }
            catch (CantidadInvalidaException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }        
        
        private void btnBitacora_Click(object sender, EventArgs e)
        {
            MessageBox.Show(hilos.Bitacora.ToString());
        }        
 
       

        #region Metodos
        public void MostrarMensajeFin(string mensaje)
        {
            MessageBox.Show(mensaje);
        }
        #endregion

    }
}

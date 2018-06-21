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

namespace MainCorreo
{
    public partial class FrmPpal : Form
    {
        Correo correo;

        public FrmPpal()
        {
            InitializeComponent();
            correo = new Correo();
        }

        private void FrmPpal_Load(object sender, EventArgs e)
        {
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtDireccion.Text != "" && mtxtTrackingID.Text != "")
            {
                Paquete nuevoPaquete = new Paquete(txtDireccion.Text, mtxtTrackingID.Text);
                nuevoPaquete.InformaEstado += paq_InformaEstado;
                try
                {
                    correo += nuevoPaquete;
                    ActualizarEstados();              
                }
                catch (TrackingIdRepetidoException ex)
                {
                    MessageBox.Show(String.Format("El tracking ID {0} ya figura en la lista de envios",
                        nuevoPaquete.TrackingID), ex.Message);
                } 
            }
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion<List<Paquete>>((IMostrar<List<Paquete>>)correo);
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion<Paquete>((IMostrar<Paquete>)lstEstadoEntregado.SelectedItem);
        }


        #region Metodos
        private void paq_InformaEstado()
        {
            if (this.InvokeRequired)
            {
                Paquete.DelegadoEstado d = new Paquete.DelegadoEstado(paq_InformaEstado);
                //this.Invoke( d, new object[] {sender, e} );
            }
            else
            {
                ActualizarEstados();
            }
        }

        private void MostrarInformacion<T>(IMostrar<T> elemento)
        {
            if (elemento != null)
                rbtMostrar.Text = elemento.MostrarDatos((T)elemento);
        }

        private void ActualizarEstados()
        {
            lstEstadoIngresado.Text = "";
            lstEstadoEnViaje.Text = "";
            lstEstadoEntregado.Text = "";
            foreach (Paquete aux in correo.Paquetes)
            {
                switch (aux.Estado)
                {
                    case Paquete.EEstado.Ingresado:
                        lstEstadoIngresado.Text = aux.ToString();
                        break;
                    case Paquete.EEstado.EnViaje:
                        lstEstadoEnViaje.Text = aux.ToString();
                        break;
                    case Paquete.EEstado.Entregado:
                        lstEstadoIngresado.Text = aux.ToString();
                        break;
                }
            }
        }
        #endregion

        private void FrmPpal_FormClosing(object sender, FormClosingEventArgs e)
        {
            correo.FinEntregas();
        }


        //falta IContainer
    }
}

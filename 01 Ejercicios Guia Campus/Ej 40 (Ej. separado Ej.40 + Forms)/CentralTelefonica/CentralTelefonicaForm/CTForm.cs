using System;
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
    public partial class CTForm : Form
    {       
        Centralita c = new Centralita("Fede Center");
        
        public CTForm()
        {
            InitializeComponent();
        }

        public Centralita Centralita
        {
            get { return c; }
            set { c = value; }
        }

        private void btnGenerarLlamada_Click(object sender, EventArgs e)
        {
            //this.Hide();
            LlamadorForm llamador = new LlamadorForm();
            llamador.Show();
        }

        private void btnFacturacionTotal_Click(object sender, EventArgs e)
        {

        }

        private void btnFacturacionLocal_Click(object sender, EventArgs e)
        {

        }

        private void btnFacturacionProvincial_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }
    }
}

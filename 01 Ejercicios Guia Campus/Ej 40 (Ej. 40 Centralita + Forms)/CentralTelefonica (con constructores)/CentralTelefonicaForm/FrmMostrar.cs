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
    public partial class FrmMostrar : Form
    {
        private Centralita centralita;
        private string opcion;
        
        public FrmMostrar(Centralita centralita)
        {
            InitializeComponent();
            this.centralita = centralita;
        }

        public string Opcion
        { 
            set { this.opcion = value; }
        }

        private void FrmMostrar_Load(object sender, EventArgs e)
        {
            switch (opcion)
            {
                case "total":
                    richTextBox1.Text = "Facturacion total: " + centralita.GananciasPorTotal.ToString();
                    break;
                case "local":
                    richTextBox1.Text = "Facturacion local: " + centralita.GananciasPorLocal.ToString();
                    break;
                case "provincial":
                    richTextBox1.Text = "Facturacion provincial: " + centralita.GananciasPorProvincial.ToString();
                    break;
            }
        }
    }
}

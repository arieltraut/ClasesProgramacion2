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

namespace Clase_08
{
    public partial class CargaEmpresa : Form
    {
        private Empresa miEmpresa;

        public CargaEmpresa(Empresa empresa)
        {
            InitializeComponent();
            this.miEmpresa = empresa;
        }

        public Empresa Empresa
        {
            get { return this.miEmpresa; }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.miEmpresa == null)
                this.miEmpresa = new Empresa(txtRazonSocial.Text, txtDireccion.Text, Single.Parse(mtxtGanancias.Text));
            else
            {
                this.miEmpresa.RazonSocial = this.txtRazonSocial.Text;
                this.miEmpresa.Direccion = this.txtDireccion.Text;
                this.miEmpresa.Ganancias = Single.Parse(mtxtGanancias.Text);
            }
                
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();

        }
    }
}

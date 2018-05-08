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
    public partial class CargaEmpleados : Form
    {
        private Empresa miEmpresa;
        
        public CargaEmpleados()
        {
            InitializeComponent();
        }
      
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtApellido.Text = "";
            txtNombre.Text = "";
            mtxtLegajo.Text = "";
            mtxtSalario.Text = "";
            cmbPuesto.Text = "";
            rtxtConsola.Text = "";
        }

        private void btnAgregarItem_Click(object sender, EventArgs e)
        {
            Empleado.EPuestoJerarquico valor;
            Enum.TryParse<Empleado.EPuestoJerarquico>(cmbPuesto.SelectedValue.ToString(), out valor);
           
            Empleado nuevoEmpleado = new Empleado(txtNombre.Text, txtApellido.Text, mtxtLegajo.Text,
                valor, Int32.Parse(mtxtSalario.Text));

            miEmpresa += nuevoEmpleado;
            rtxtConsola.Text = miEmpresa.MostrarEmpresa();
        }


        private void CargaEmpleados_Load(object sender, EventArgs e)
        {
            cmbPuesto.DataSource = Enum.GetValues(typeof(Empleado.EPuestoJerarquico));
            btnEmpresa_Click(sender, e);
        }


        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            CargaEmpresa cEmpresa = new CargaEmpresa(this.miEmpresa);
            cEmpresa.ShowDialog();

            if (cEmpresa.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                this.miEmpresa = cEmpresa.Empresa;
            }
        }



    }
}

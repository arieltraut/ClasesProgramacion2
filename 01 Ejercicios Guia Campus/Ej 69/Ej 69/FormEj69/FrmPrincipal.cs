using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormEj69
{
    public partial class FrmPrincipal : Form
    {
        public delegate void DelegadoString(string s);
        private event DelegadoString delegado; //manejador de eventos

     
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void testDelegadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTestDelegados frm2 = new frmTestDelegados();
            frm2.Show(this);
            //frm2.MdiParent = this;
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDatos frm3 = new FrmDatos();
            frm3.Show(this);
            //frm3.MdiParent = this;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            FrmDatos frm = new FrmDatos();
            delegado += frm.ActualizarNombre;

        }
    }
}

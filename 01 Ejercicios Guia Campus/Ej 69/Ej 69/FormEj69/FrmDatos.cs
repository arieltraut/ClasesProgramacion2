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
    public partial class FrmDatos : Form
    {
        public void ActualizarNombre(string s)
        {
            label1.Text = s;
        }
        
        
        public FrmDatos()
        {
            InitializeComponent();
        }
    }
}

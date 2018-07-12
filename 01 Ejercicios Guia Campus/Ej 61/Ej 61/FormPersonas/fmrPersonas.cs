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

namespace FormPersonas
{
    public partial class fmrPersonas : Form
    {
        private List<Persona> listaPersonas;

        public fmrPersonas()
        {
            InitializeComponent();
            //lstPersonas.MouseDoubleClick += new MouseEventHandler(listBox1_DoubleClick);

        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            lstPersonas.Items.Clear();
            listaPersonas = PersonaDAO.Leer();
            lstPersonas.DisplayMember = "Info";
            lstPersonas.ValueMember = "Id";
            foreach (Persona persona in listaPersonas)
            {
                lstPersonas.Items.Add(persona);

                //lstPersonas.Items.Add(String.Format("{0} {1} {2}\n", persona.Id.ToString(), persona.Nombre.ToString(), persona.Apellido.ToString()));
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
            //PersonaDAO.Modificar(PersonaDAO.LeerPorID(
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            PersonaDAO.Guardar(new Persona(txtNombre.Text,txtApellido.Text));
        }

        private void lstPersonas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.lstPersonas.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                txtNombre.Text = ((Persona)lstPersonas.SelectedItem).Nombre;
                txtApellido.Text = ((Persona)lstPersonas.SelectedItem).Apellido;
            }
        }
        
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            PersonaDAO.Eliminar((Persona)lstPersonas.SelectedItem);
        }




    }
}

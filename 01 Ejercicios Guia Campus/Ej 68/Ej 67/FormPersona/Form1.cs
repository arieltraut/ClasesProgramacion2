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

namespace FormPersona
{
    public partial class Form1 : Form
    {
        private Persona persona;
        private event DelegadoString delegado; //manejador de eventos

        static void NotificarCambio(string mensaje)
        {
            MessageBox.Show(mensaje);
        }
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            delegado += NotificarCambio;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (persona == null)
            {
                persona = new Persona(textBox1.Text, textBox2.Text);
                btnCrear.Text = "Actualizar";
                delegado.Invoke(String.Format("Se ha creado la persona {0}", persona.Mostrar()));
            }
            else
            {
                persona.Nombre = textBox1.Text;
                persona.Apellido = textBox2.Text;
                delegado.Invoke(String.Format("Se ha editado la persona {0}", persona.Mostrar()));
            }


        }
    }
}

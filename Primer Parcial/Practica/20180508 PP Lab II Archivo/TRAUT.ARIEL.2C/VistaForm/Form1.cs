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

namespace VistaForm
{
    public partial class Form1 : Form
    {
        Curso curso;

        public Form1()
        {
            InitializeComponent();
            cursoDiv.DataSource = Enum.GetValues(typeof(Divisiones));
            alumnoDiv.DataSource = Enum.GetValues(typeof(Divisiones));
        }

        private void buttonCrearCurso_Click(object sender, EventArgs e)
        {
            Divisiones division;
            Enum.TryParse<Divisiones>(cursoDiv.SelectedValue.ToString(), out division);
            
            curso = new Curso((short)cursoAnio.Value, division,
                new Profesor(cursoNombre.Text, cursoApellido.Text, cursoDni.Text));
        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = (string)curso;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Divisiones division;
            Enum.TryParse<Divisiones>(alumnoDiv.SelectedValue.ToString(), out division);

            Alumno nuevoAlumno = new Alumno(alumnoNombre.Text, alumnoApellido.Text, 
                alumnoLegajo.Text,(short)alumnoAnio.Value, division);

            curso += nuevoAlumno;

        }
    }
}

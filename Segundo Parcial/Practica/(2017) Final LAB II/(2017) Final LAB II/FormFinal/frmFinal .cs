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
using System.Threading;

namespace FormFinal
{
    public partial class frmFinal : Form
    {
        private MEspecialista medicoEspecialista;
        private MGeneral medicoGeneral;
        private Thread mocker;
        private Queue<Paciente> pacientesEnEspera;
        
        
        public frmFinal()
        {
            InitializeComponent();
            this.medicoGeneral = new MGeneral("Luis", "Salinas");
            this.medicoEspecialista = new MEspecialista("Jorge", "Iglesias",
            MEspecialista.Especialidad.Traumatologo);
            this.mocker = new Thread(MockPacientes);
            this.pacientesEnEspera = new Queue<Paciente>();
        }

        private void frmFinal_Load(object sender, EventArgs e)
        {
            this.mocker.Start();
        }

        private void frmFinal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.mocker.IsAlive)
                this.mocker.Abort();
        }

        private void btnGeneral_Click(object sender, EventArgs e)
        {
            this.AtenderPacientes(medicoGeneral);
        }

        private void btnEspecialista_Click(object sender, EventArgs e)
        {
            this.AtenderPacientes(medicoEspecialista);
        }        

        
        
        #region Metodos
        private void MockPacientes()
        {
            List<Paciente> pacientes = new List<Paciente> { new Paciente("Clark", "Kent"), new Paciente("Bruce", "Wayne"), new Paciente("Diana", "Prince") };
            foreach (Paciente aux in pacientes)
            {
                this.pacientesEnEspera.Enqueue(aux);
                Thread.Sleep(5000);
            }
        }

        private void AtenderPacientes(IMedico iMedico)
        {
            if (this.pacientesEnEspera.Count > 0)
            {
                Paciente aux = this.pacientesEnEspera.Dequeue();
                ((Medico)iMedico).AtenderA = aux;
                ((Medico)iMedico).AtencionFinalizada += FinAtencion;               
                iMedico.IniciarAtencion(aux);
            }
        }

        private void FinAtencion(Paciente p, Medico m)
        {
            MessageBox.Show(String.Format("Finalizó la atención de {0} por {1}!",m.EstaAtendiendoA, m.ToString()));
        }
        
        #endregion




    }
}

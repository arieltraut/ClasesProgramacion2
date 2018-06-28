using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paciente : Persona
    {
        private int turno;
        private static int ultimoTurnoDado;

        #region Constructor
        static Paciente()
        {
            ultimoTurnoDado = 0;
        }

        public Paciente(string nombre, string apellido) : base(nombre, apellido)
        {
            ultimoTurnoDado++;
            this.turno = ultimoTurnoDado;
        }

        public Paciente(string nombre, string apellido, int turno) : this(nombre, apellido)
        {
            ultimoTurnoDado = turno;
            this.turno = turno;
        }
        #endregion  



        #region Propiedades
        public int Turno
        {
            get { return this.turno; }
            set { this.turno = value; }
        }
        #endregion

        #region Metodos
        public override string ToString()
        {
            return String.Format("Turno Nº{0}: {2}, {1}", Turno, this.apellido, this.nombre);
        }
        
        #endregion

    }
}

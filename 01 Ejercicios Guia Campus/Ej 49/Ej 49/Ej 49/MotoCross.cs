using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_49
{
    public class MotoCross : VehiculoDeCarrera
    {
        short cilindrada;

        public MotoCross(short numero, string escuderia) : base(numero,escuderia)
        {
        }

        public MotoCross(short numero, string escuderia, short cilindrada)
            : this(numero, escuderia)
        {
            this.cilindrada = cilindrada;
        }



        public short Cilindrada
        {
            get { return this.cilindrada; }
            set { this.cilindrada = value; }
        }




        public static bool operator ==(MotoCross a1, MotoCross a2)
        {
            return (a1.Numero == a2.Numero && a1.Escuderia == a2.Escuderia && a1.Cilindrada == a2.Cilindrada);
        }

        public static bool operator !=(MotoCross a1, MotoCross a2)
        {
            return !(a1 == a2);
        }

        public override bool Equals(object obj)
        {
            return (MotoCross)obj == this;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }




        public new string Mostrar()
        {
            return String.Format("{0}\tCilindrada: {1}", base.Mostrar(), this.cilindrada);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_43
{
    public class AutoF1 : VehiculoDeCarrera
    {
        short caballosDeFuerza;

        public AutoF1(short numero, string escuderia) : base(numero,escuderia)
        {
        }

        public AutoF1(short numero, string escuderia, short caballosDeFuerza)
            : this(numero, escuderia)
        {
            this.caballosDeFuerza = caballosDeFuerza;
        }



        public short CaballosDeFuerza
        {
            get { return this.caballosDeFuerza; }
            set { this.caballosDeFuerza = value; }
        }



        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            return (a1.Numero == a2.Numero && a1.Escuderia == a2.Escuderia && a1.CaballosDeFuerza == a2.CaballosDeFuerza);
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }

        public override bool Equals(object obj)
        {
            return (AutoF1)obj == this;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public new string Mostrar()
        {
            return String.Format("{0}\tCaballos: {1}", base.Mostrar(), this.caballosDeFuerza);
        }
    }
}

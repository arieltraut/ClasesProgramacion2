using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_49
{
    public abstract class VehiculoDeCarrera
    {
        short cantidadCombustible;
        bool enCompetencia;
        string escuderia;
        short numero;
        short vueltasRestantes;

        public VehiculoDeCarrera(short numero, string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
            this.enCompetencia = false;
            this.cantidadCombustible = 0;
            this.vueltasRestantes = 0;
        }


        public short Numero
        {
            get { return this.numero; }
            set { this.numero = value; }
        }

        public string Escuderia
        {
            get { return this.escuderia; }
            set { this.escuderia = value; }
        }

        public short CantidadCombustible
        {
            get { return this.cantidadCombustible; }
            set { this.cantidadCombustible = value; }
        }

        public bool EnCompetencia
        {
            get { return this.enCompetencia; }
            set { this.enCompetencia = value; }
        }

        public short VueltasRestantes
        {
            get { return this.vueltasRestantes; }
            set { this.vueltasRestantes = value; }
        }



        public static bool operator ==(VehiculoDeCarrera a1, VehiculoDeCarrera a2)
        {
            return (a1.Numero == a2.Numero && a1.Escuderia == a2.Escuderia);
        }

        public static bool operator !=(VehiculoDeCarrera a1, VehiculoDeCarrera a2)
        {
            return !(a1 == a2);
        }

        public override bool Equals(object obj)
        {
            return (VehiculoDeCarrera)obj == this;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public string Mostrar()
        {
            return String.Format("Numero: {0}\tEscuderia: {1}\tEn Competencia: {2}\tCant.Comb: {3}\tVueltas Restantes: {4}",
                this.numero, this.escuderia, this.EnCompetencia, this.CantidadCombustible, this.VueltasRestantes);
        }
    }
}

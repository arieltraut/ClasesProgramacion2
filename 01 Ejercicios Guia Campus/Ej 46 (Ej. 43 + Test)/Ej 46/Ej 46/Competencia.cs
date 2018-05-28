using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_46
{
    public class Competencia
    {
        public enum TipoCompetencia
        {
            F1,
            MotoCross
        }
               
        short cantidadCompetidores;
        short cantidadVueltas;
        List<VehiculoDeCarrera> competidores;
        TipoCompetencia tipo;


        private Competencia()
        {
            competidores = new List<VehiculoDeCarrera>();
        }

        public Competencia(short cantidadVueltas, short cantidadCompetidores, TipoCompetencia tipo) : this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
            this.tipo = tipo;
        }




        public short CantidadCompetidores
        {
            get { return this.cantidadCompetidores; }
            set { this.cantidadCompetidores = value; }
        }

        public short CantidadVueltas    
        {
            get { return this.cantidadVueltas; }
            set { this.cantidadVueltas = value; }
        }

        public VehiculoDeCarrera this[int i]
        {
            get { return this.competidores[i]; }
        }

        public TipoCompetencia TipoDeCompetencia
        {
            get { return this.tipo; }
            set { this.tipo = value; }
        }

        public List<VehiculoDeCarrera> Competidores
        {
            get { return this.competidores; }
        }





        public static bool operator +(Competencia c, VehiculoDeCarrera a)
        {
            try
            {
                if (c == a)
                { }
            }
            catch (CompetenciaNoDisponibleException e)
            {
                Console.WriteLine(e.Message);
                throw new CompetenciaNoDisponibleException("Competencia incorrecta", "Competencia", "+");
            }                
                        
            if ((c.competidores.Count < c.cantidadCompetidores) && c != a)
            {
                Random r = new Random();
                c.competidores.Add(a);
                a.EnCompetencia = true;
                a.VueltasRestantes = c.cantidadVueltas;
                a.CantidadCombustible = (short)r.Next(15, 100);

                return true;
            }
            return false;
        }

        public static bool operator -(Competencia c, VehiculoDeCarrera a)
        {
            if (c == a)
            {
                c.competidores.Remove(a);
                return true;
            }
            return false;
        }

        public static bool operator ==(Competencia c, VehiculoDeCarrera a)
        {
            bool retorno = false;          
            if ((c.TipoDeCompetencia == TipoCompetencia.F1 && a is AutoF1)
                || (c.TipoDeCompetencia == TipoCompetencia.MotoCross && a is MotoCross))
            {
                switch (c.TipoDeCompetencia)
                {
                    case TipoCompetencia.F1:
                        foreach (AutoF1 auto in c.competidores)
                        {
                            if (auto == (AutoF1)a)
                            {
                                retorno = true;
                                break;
                            }
                        }
                        break;
                    case TipoCompetencia.MotoCross:
                        foreach (MotoCross moto in c.competidores)
                        {
                            if (moto == (MotoCross)a)
                            {
                                retorno = true;
                                break;
                            }
                        }
                        break;
                }
            }
            else
                throw new CompetenciaNoDisponibleException("El vehículo no corresponde a la competencia", "Competencia", "==");
            return retorno;
        }

        public static bool operator !=(Competencia c, VehiculoDeCarrera a)
        {
            return !(c == a);
        }

        public override bool Equals(object obj)
        {
            return (Competencia)obj == this;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            foreach (VehiculoDeCarrera a in this.competidores)
            {
                sb.AppendLine(a.Mostrar());
            }
            return sb.ToString();
        }

    }
}

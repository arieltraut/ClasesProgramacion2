using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_49
{
    public class Competencia<T> where T : VehiculoDeCarrera
    {
        public enum TipoCompetencia
        {
            F1,
            MotoCross
        }
               
        short cantidadCompetidores;
        short cantidadVueltas;
        List<T> competidores;
        TipoCompetencia tipo;


        private Competencia()
        {
            competidores = new List<T>();
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

        public List<T> Competidores
        {
            get { return this.competidores; }
        }





        public static bool operator +(Competencia<T> c, T a)
        {
            try
            {
                if (c == a)
                { }
            }
            catch (CompetenciaNoDisponibleException e)
            {
                Console.WriteLine(e.ToString());
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

        public static bool operator -(Competencia<T> c, T a)
        {
            if (c == a)
            {
                c.competidores.Remove(a);
                return true;
            }
            return false;
        }

        public static bool operator ==(Competencia<T> c, T a)
        {
            bool retorno = false;          
            if ((c.TipoDeCompetencia == TipoCompetencia.F1 && a is AutoF1)
                || (c.TipoDeCompetencia == TipoCompetencia.MotoCross && a is MotoCross))
            {
                switch (c.TipoDeCompetencia)
                {
                    case TipoCompetencia.F1:
                        foreach (VehiculoDeCarrera auto in c.competidores)
                        {
                            //AutoF1 aux = (AutoF1)Convert.ChangeType(a, typeof(AutoF1));
                            if (auto is AutoF1 && auto == a)
                            {
                                retorno = true;
                                break;
                            }
                        }
                        break;
                    case TipoCompetencia.MotoCross:
                        foreach (VehiculoDeCarrera moto in c.competidores)
                        {
                            if (moto is MotoCross && moto == a)
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

        public static bool operator !=(Competencia<T> c, T a)
        {
            return !(c == a);
        }

        public override bool Equals(object obj)
        {
            return (Competencia<T>)obj == this;
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

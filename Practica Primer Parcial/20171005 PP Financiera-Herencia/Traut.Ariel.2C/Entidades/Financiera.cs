using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using PrestamosPersonales;

namespace Entidades
{
    public class Financiera
    {
        private List<Prestamo> listaDePrestamos;
        private string razonSocial;


        private Financiera()
        {
            listaDePrestamos = new List<Prestamo>();
        }

        public Financiera(string razonSocial) : this ()
        {
            this.razonSocial = razonSocial;
        }



        public float InteresesEnDolares
        {
            get { return this.CalcularInteresGanado(TipoDePrestamo.Dolares); }
        }

        public float InteresesEnPesos
        {
            get { return this.CalcularInteresGanado(TipoDePrestamo.Pesos); }
        }

        public float InteresesTotales
        {
            get { return this.CalcularInteresGanado(TipoDePrestamo.Todos); }
        }

        public List<Prestamo> ListaDePrestamos
        {
            get { return this.listaDePrestamos; }
        }

        public string RazonSocial
        {
            get { return this.razonSocial; }
        }




        public void OrdenarPrestamos()
        {
            ListaDePrestamos.Sort(Prestamo.OrdenarPorFecha);
        }

        public static string Mostrar(Financiera financiera)
        {
            return (string)financiera;
        }


        public static explicit operator string(Financiera financiera)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Razon Social: {0}\tInt. Total: {1}\tInt. Pesos: {2}\tInt. Dolar: {3}\n\n",
                financiera.RazonSocial, financiera.InteresesTotales, financiera.InteresesEnPesos, financiera.InteresesEnDolares);

            financiera.OrdenarPrestamos();
            foreach (Prestamo prestamo in financiera.ListaDePrestamos)
            {
                sb.AppendLine(prestamo.Mostrar());
            }
            
            return sb.ToString();
        }

        private float CalcularInteresGanado(TipoDePrestamo tipoPrestamo)
        {
            float acumIntPesos = 0, acumIntDolar = 0, retorno = 0;
            foreach (Prestamo prestamo in this.ListaDePrestamos)
            {
                if (prestamo is PrestamoPesos)
                    acumIntPesos += ((PrestamoPesos)prestamo).Interes;
                else
                    acumIntDolar += ((PrestamoDolar)prestamo).Interes;
            }
            switch(tipoPrestamo)
            {
                case (TipoDePrestamo.Pesos):
                    retorno = acumIntPesos;
                    break;
                case (TipoDePrestamo.Dolares):
                    retorno = acumIntDolar;
                    break;
                case (TipoDePrestamo.Todos):
                    retorno = acumIntPesos + acumIntDolar;
                    break;
            }
            return retorno;
        }





        public static bool operator == (Financiera financiera, Prestamo prestamo)
        {
            foreach (Prestamo aux in financiera.listaDePrestamos)
            {
                if (aux == prestamo)
                    return true;
            }
            return false;
        }

        public static bool operator !=(Financiera financiera, Prestamo prestamo)
        {
            return !(financiera == prestamo);
        }

        public static Financiera operator +(Financiera financiera, Prestamo prestamoNuevo)
        {
            if(financiera != prestamoNuevo)
                financiera.listaDePrestamos.Add(prestamoNuevo);
            return financiera;
            
        }
    }
}

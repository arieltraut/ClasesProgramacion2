using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_16
{
    class Alumno
    {
        byte _nota1;
        byte _nota2;
        float _notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;

        public void CalcularFinal()
        {
            Random r = new Random();
            if (this._nota1 >= 4 && this._nota2 >= 4)
            {
                this._notaFinal = r.Next(0, 10);
            }
            else
            {
                this._notaFinal = -1;
            }
        }
        
        public void Estudiar(byte notaUno, byte notaDos)
        {
            this._nota1 = notaUno;
            this._nota2 = notaDos;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.AppendLine("Nombre : " + this.nombre); //appenformat
            sb.AppendLine("Apellido : " + this.apellido);
            sb.AppendLine("Legajo : " + this.legajo);
            sb.AppendLine("Nota 1 : " + this._nota1);
            sb.AppendLine("Nota 2 : " + this._nota2);
            if (this._notaFinal != -1)
            {
                sb.AppendLine("Nota Final : " + this._notaFinal);
            }
            else
            {
                sb.AppendLine("Alumno desaprobado");
            }
            return sb.ToString();
        }

    }
}

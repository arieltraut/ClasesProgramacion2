using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno();
            Alumno alumno2 = new Alumno();
            Alumno alumno3 = new Alumno();
            
            alumno1.nombre = "Franco";
            alumno1.apellido = "XX";
            alumno1.legajo = 1;
            alumno1.Estudiar(8,6);
            alumno2.nombre = "Ariel";
            alumno2.apellido = "YY";
            alumno2.legajo = 2;
            alumno2.Estudiar(2,6);
            alumno3.nombre = "Mariano";
            alumno3.apellido = "ZZ";
            alumno3.legajo = 3;
            alumno3.Estudiar(10,7);
            
            alumno1.CalcularFinal();
            alumno2.CalcularFinal();
            alumno3.CalcularFinal();

            Console.WriteLine(alumno1.Mostrar());
            Console.WriteLine(alumno2.Mostrar());
            Console.WriteLine(alumno3.Mostrar());
            Console.ReadKey();
         }
       }
}




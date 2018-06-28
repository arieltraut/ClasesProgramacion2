using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace ConsolaPrueba
{
    class Program
    {
        static void Main(string[] args)
        {
            Paciente paciente = new Paciente("ariel", "traut",5);
            Paciente paciente2 = new Paciente("ariel", "xx");
            Console.WriteLine(paciente.ToString());
            Console.WriteLine(paciente2.ToString());
            Console.ReadKey();
        }
    }
}

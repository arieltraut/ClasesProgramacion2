﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Test_por_consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Numero num1 = new Numero(30);
            Numero num2 = new Numero(10);

            
            Console.WriteLine(Calculadora.Operar(num1,num2,"-"));
            /*Console.WriteLine(num1 - num2);
            Console.WriteLine(num1 * num2);
            Console.WriteLine(num1 / num2);*/
            Console.ReadKey();
        }
    }
}
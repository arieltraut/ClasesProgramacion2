using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CentralitaHerencia;
using System.Collections.Generic;

namespace CentralitaTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void a()
        {

            Centralita centralita = new Centralita("CentralTest");
            Assert.IsNotNull(centralita.Llamadas);

        }

        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]    
        public void b()
        {
            Centralita centralita = new Centralita("CentralTest");

            
            Local l1 = new Local("Lanús", 90, "San Rafael", 3.99f);
            Local l2 = new Local("Lanús", 45, "San Rafael", 1.99f);

            centralita += l1;
            centralita += l2;
            
        }

        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void c()
        {
            Centralita centralita = new Centralita("CentralTest");


            Provincial l1 = new Provincial("Morón", Provincial.Franja.Franja_1, 21, "Bernal");
            Provincial l2 = new Provincial("Morón", Provincial.Franja.Franja_1, 21, "Bernal");

            centralita += l1;
            centralita += l2;

        }

        [TestMethod]
        public void d()
        {
            Centralita centralita = new Centralita("CentralTest");

            Local l1 = new Local("Lanús", 90, "San Rafael", 3.99f);
            Local l2 = new Local("Lanús", 45, "San Rafael", 1.99f);
            Provincial p1 = new Provincial("Lanús", Provincial.Franja.Franja_1, 21, "San Rafael");
            Provincial p2 = new Provincial("Lanús", Provincial.Franja.Franja_1, 21, "San Rafael");

            
            Assert.IsTrue(l1 == l2);
            Assert.IsTrue(p1 == p2);
            Assert.IsFalse(l1 == p1);
            Assert.IsFalse(l1 == p2);
            Assert.IsFalse(l2 == p1);
            Assert.IsFalse(l2 == p2);

        }
    }
}

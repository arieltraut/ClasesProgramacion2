using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ej_46;

namespace TestCompetencia
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestListaInstanciada()
        {
            Competencia competencia = new Competencia(5, 5, Competencia.TipoCompetencia.F1);
            Assert.IsNotNull(competencia.Competidores);
        }

        [TestMethod]
        [ExpectedException(typeof(CompetenciaNoDisponibleException))]
        public void LanzarExcepcion()
        {
            Competencia competencia = new Competencia(5, 5, Competencia.TipoCompetencia.MotoCross);
            AutoF1 auto = new AutoF1(1, "Ferrari");         
            bool cargado = (competencia + auto) ? true : false;
        }

        [TestMethod]
        public void NoLanzarExcepcion()
        {
            Competencia competencia = new Competencia(5, 5, Competencia.TipoCompetencia.MotoCross);
            MotoCross moto = new MotoCross(1, "Kawasaki");
            bool cargado = (competencia + moto) ? true : false;
        }

        [TestMethod]
        public void FiguraEnLista()
        {
            Competencia competencia = new Competencia(5, 5, Competencia.TipoCompetencia.MotoCross);
            MotoCross moto = new MotoCross(1, "Kawasaki");
            bool cargado = (competencia + moto) ? true : false;

            Assert.IsTrue(competencia == moto);
        }

        [TestMethod]
        public void EliminadoDeLista()
        {
            Competencia competencia = new Competencia(5, 5, Competencia.TipoCompetencia.MotoCross);
            MotoCross moto = new MotoCross(1, "Kawasaki");
            bool cargado = (competencia + moto) ? true : false;
            bool eliminado = (competencia - moto) ? true : false;

            Assert.IsTrue(competencia != moto);
        }
    }
}

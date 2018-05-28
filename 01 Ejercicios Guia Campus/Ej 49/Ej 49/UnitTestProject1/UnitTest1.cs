using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ej_49;

namespace TestCompetencia
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestListaInstanciada()
        {
            Competencia<VehiculoDeCarrera> competencia = new Competencia<VehiculoDeCarrera>(5, 5, Competencia<VehiculoDeCarrera>.TipoCompetencia.F1);
            Assert.IsNotNull(competencia.Competidores);
        }

        [TestMethod]
        [ExpectedException(typeof(CompetenciaNoDisponibleException))]
        public void LanzarExcepcion()
        {
            Competencia<VehiculoDeCarrera> competencia = new Competencia<VehiculoDeCarrera>(5, 5, Competencia<VehiculoDeCarrera>.TipoCompetencia.MotoCross);
            AutoF1 auto = new AutoF1(1, "Ferrari");
            bool cargado = (competencia + auto) ? true : false;
        }

        [TestMethod]
        public void NoLanzarExcepcion()
        {
            Competencia<VehiculoDeCarrera> competencia = new Competencia<VehiculoDeCarrera>(5, 5, Competencia<VehiculoDeCarrera>.TipoCompetencia.MotoCross);
            MotoCross moto = new MotoCross(1, "Kawasaki");
            bool cargado = (competencia + moto) ? true : false;
        }

        [TestMethod]
        public void FiguraEnLista()
        {
            Competencia<VehiculoDeCarrera> competencia = new Competencia<VehiculoDeCarrera>(5, 5, Competencia<VehiculoDeCarrera>.TipoCompetencia.MotoCross);
            MotoCross moto = new MotoCross(1, "Kawasaki");
            bool cargado = (competencia + moto) ? true : false;

            Assert.IsTrue(competencia == moto);
        }

        [TestMethod]
        public void EliminadoDeLista()
        {
            Competencia<VehiculoDeCarrera> competencia = new Competencia<VehiculoDeCarrera>(5, 5, Competencia<VehiculoDeCarrera>.TipoCompetencia.MotoCross);
            MotoCross moto = new MotoCross(1, "Kawasaki");
            bool cargado = (competencia + moto) ? true : false;
            bool eliminado = (competencia - moto) ? true : false;

            Assert.IsTrue(competencia != moto);
        }
    }
}

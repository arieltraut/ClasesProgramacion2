using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Excepciones;
using Entidades;
using System.IO;

namespace TestVotacion
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(ErrorArchivoException))]
        public void TestSerializar()
        {
            SerializarBinaria binaryGuardar = new SerializarBinaria();
            binaryGuardar.Guardar(@"C:\RutaErronea", new Votacion());
        }

        [TestMethod]
        public void TestVotacionSenadores()
        {
            
        }
    }
}

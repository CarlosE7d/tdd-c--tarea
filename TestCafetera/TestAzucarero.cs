using MaquinaDeCafe;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = NUnit.Framework.Assert;

namespace TestCafetera{

    
    public class TestAzucarero
    {

        [Test]
        public void deberiaDevolverVerdaderoSiHaySuficienteAzucarEnElAzucarero()
        {
            Azucarero azucarero = new Azucarero(10);

            bool resultado = azucarero.hasAzucar(5);

            Assert.IsTrue(resultado);
        }

    }
}
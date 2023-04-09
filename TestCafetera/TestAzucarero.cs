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

            resultado = azucarero.hasAzucar(10);

            Assert.IsTrue(resultado);
        }

        [Test]
        public void deberiaDevolverFalsoPorqueNoHaySuficienteAzucar()
        {
            Azucarero azucarero = new Azucarero(10);
            bool resultado = azucarero.hasAzucar(15);

            Assert.IsFalse(resultado);
        }

        [Test]
        public void deberiaRestarAzucarAlAzucarero()
        {
            Azucarero azucarero = new Azucarero(10);
            azucarero.giveAzucar(5);

            Assert.AreEqual(5, azucarero.getCantidadDeAzucar());

            azucarero.giveAzucar(2);

            Assert.AreEqual(3, azucarero.getCantidadDeAzucar());

        }

    }
}
using MaquinaDeCafe;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = NUnit.Framework.Assert;

namespace TestCafetera
{
    public class Testcafe
    {

        [Test]
        public void deberiaDevolverVerdaderoSiExisteCafe()
        {
            Cafetera cafetera = new Cafetera(10);

            bool resultado = cafetera.hasCafe(10);

            Assert.AreEqual(true, resultado);   
        }

        [Test]
        public void deberiaDevolverFalsoSiNoExisteCafe()
        {
            Cafetera cafetera = new Cafetera(10);
            bool resultado = cafetera.hasCafe(11);

            Assert.AreEqual(false, resultado);
        }

        [Test]
        public void deberiaRestarCafeALaCafetera()
        {
            Cafetera cafetera = new Cafetera(10);

            cafetera.giveCafe(7);

            Assert.AreEqual(3, cafetera.getCantidadCafe());
        }

    }
}
using MaquinaDeCafe;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = NUnit.Framework.Assert;

namespace TestCafetera
{
    public class TestsVaso
    {
       

        [Test]
        public void deberiaDevolverVerdaderoSiExistenVasos()
        {
            Vaso vasosPequeños = new Vaso(2, 10);

            bool resultado = vasosPequeños.hasVasos(2);

            Assert.AreEqual(true, resultado);
        }
    }
}
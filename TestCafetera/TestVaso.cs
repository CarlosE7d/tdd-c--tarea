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
            Vaso vasosPeque�os = new Vaso(2, 10);

            bool resultado = vasosPeque�os.hasVasos(2);

            Assert.AreEqual(true, resultado);
        }
    }
}
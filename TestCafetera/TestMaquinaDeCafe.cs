using MaquinaDeCafe;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework.Constraints;
using Assert = NUnit.Framework.Assert;

namespace TestCafetera
{
    public class TestMaquinaDeCafe
    {
        [Test]
        public void debeDevolverUnVasoPequeno()
        {
            Cafetera cafetera = new Cafetera(50);
            Vaso vasoPequeno = new Vaso(5, 10);
            Vaso vasoMediano = new Vaso(5, 20);
            Vaso vasoGrande = new Vaso(5, 30);
            Azucarero azucarero = new Azucarero(20);


            MaquinaCafe maquinaDeCafe = new MaquinaCafe();

            maquinaDeCafe.setCafetera(cafetera);
            maquinaDeCafe.setVasosPequeno(vasoPequeno);
            maquinaDeCafe.setVasosMeadiano(vasoMediano);
            maquinaDeCafe.setVasosGrande(vasoGrande);
            maquinaDeCafe.setAzucarero(azucarero);

            Vaso vaso = maquinaDeCafe.getTipoDeVaso("pequeno");

            Assert.AreEqual(maquinaDeCafe.vasoPequeno, vaso);
        }

    }
}
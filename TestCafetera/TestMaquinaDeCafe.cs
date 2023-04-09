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
        [Test]
        public void debeDevolverUnVasoMediano()
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

            Vaso vaso = maquinaDeCafe.getTipoDeVaso("mediano");

            Assert.AreEqual(maquinaDeCafe.vasoMediano, vaso);
        }
        [Test]
        public void debeDevolverUnVasoGrande()
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

            Vaso vaso = maquinaDeCafe.getTipoDeVaso("grande");

            Assert.AreEqual(maquinaDeCafe.vasoGrande, vaso);
        }

        [Test]
        public void debeDevolverNoHayVasos()
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

            string resultado = maquinaDeCafe.getVasoDeCafe(vaso, 10, 2);

            Assert.AreEqual("No Hay Vasos", resultado);
        }
        [Test]
        public void debeDevolverNoHayCafe()
        {
            Cafetera cafetera = new Cafetera(5);
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

            string resultado = maquinaDeCafe.getVasoDeCafe(vaso, 1, 2);

            Assert.AreEqual("No Hay Cafe", resultado);
        }
    }
}
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

            Assert.That(vaso, Is.EqualTo(maquinaDeCafe.vasoPequeno));
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

            Assert.That(vaso, Is.EqualTo(maquinaDeCafe.vasoMediano));
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

            Assert.That(vaso, Is.EqualTo(maquinaDeCafe.vasoGrande));
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

            Assert.That(resultado, Is.EqualTo("No Hay Vasos"));
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

            Assert.That(resultado, Is.EqualTo("No Hay Cafe"));
        }
        [Test]
        public void debeDevolverNoHayAzucar()
        {
            Cafetera cafetera = new Cafetera(50);
            Vaso vasoPequeno = new Vaso(5, 10);
            Vaso vasoMediano = new Vaso(5, 20);
            Vaso vasoGrande = new Vaso(5, 30);
            Azucarero azucarero = new Azucarero(2);


            MaquinaCafe maquinaDeCafe = new MaquinaCafe();

            maquinaDeCafe.setCafetera(cafetera);
            maquinaDeCafe.setVasosPequeno(vasoPequeno);
            maquinaDeCafe.setVasosMeadiano(vasoMediano);
            maquinaDeCafe.setVasosGrande(vasoGrande);
            maquinaDeCafe.setAzucarero(azucarero);

            Vaso vaso = maquinaDeCafe.getTipoDeVaso("pequeno");

            string resultado = maquinaDeCafe.getVasoDeCafe(vaso, 1, 3);

            Assert.That(resultado, Is.EqualTo("No Hay Azucar"));
        }
        [Test]
        public void debeRestarCafe()
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

            maquinaDeCafe.getVasoDeCafe(vaso, 1, 3);

            int resultado = maquinaDeCafe.getCafetera().getCantidadCafe();

            Assert.That(resultado, Is.EqualTo(40));
        }
        [Test]
        public void debeRestarVaso()
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

            maquinaDeCafe.getVasoDeCafe(vaso, 1, 3);

            int resultado = maquinaDeCafe.getVasosPequeno().getCantidadVasos();

            Assert.That(resultado, Is.EqualTo(4));
        }
        [Test]
        public void debeRestarAzucar()
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

            maquinaDeCafe.getVasoDeCafe(vaso, 1, 3);

            int resultado = maquinaDeCafe.getAzucarero().getCantidadDeAzucar();

            Assert.That(resultado, Is.EqualTo(17));
        }
        [Test]
        public void deberiaDevolverFelicitaciones()
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
       

            String resultado = maquinaDeCafe.getVasoDeCafe(vaso,1,3);

            Assert.That(resultado, Is.EqualTo("Felicitaciones"));
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeCafe
{
    public class MaquinaCafe
    {
        public Cafetera? cafetera;
        public Vaso vasoPequeno;
        public Vaso vasoMediano;
        public Vaso vasoGrande;
        public Azucarero? azucar;
        public void setVasosPequeno(Vaso vasoPequeno)
        {
            this.vasoPequeno = vasoPequeno;
        }

        public void setVasosMeadiano(Vaso vasoMediano)
        {
            this.vasoMediano = vasoMediano;
        }

        public void setVasosGrande(Vaso vasoGrande)
        {
            this.vasoGrande = vasoGrande;
        }

        public void setAzucarero(Azucarero azucarero)
        {
            this.azucar = azucarero;
        }

        public void setCafetera(Cafetera cafetera)
        {
            this.cafetera = cafetera;
        }

        public Vaso getTipoDeVaso(string tipoV)
        {
            if (tipoV.Equals("pequeno"))
            {
                return this.vasoPequeno;
            }else if (tipoV.Equals("mediano"))
            {
                return this.vasoMediano;
            }
            else
            {
                return this.vasoGrande;
            }
        }

        public string getVasoDeCafe(Vaso vaso, int cantVasos, int cantAzucar)
        {
            if(vaso.cantidadVaso <= cantVasos)
            {
                return "No Hay Vasos";
            }

            int cantidadTotalCafe = vaso.getContenido() * cantVasos;

            if(cantidadTotalCafe > this.cafetera.getCantidadCafe())
            {
                return "No Hay Cafe";
            }

            if(cantAzucar > this.azucar.getCantidadDeAzucar())
            {
                return "No Hay Azucar";
            }

            this.cafetera.setCantidadDeCafe(this.cafetera.getCantidadDeCafe() - cantidadTotalCafe);
            vaso.setCantidadVasos(vaso.getCantidadVasos() - cantVasos);
            this.azucar.setCantidadDeAzucar(this.getAzucar().getCantidadDeAzucar() - cantAzucar);

            return "Felicitaciones";
        }


        public Azucarero getAzucar()
        {
            return this.azucar;
        }

        public Cafetera getCafetera()
        {
            return this.cafetera;
        }

        public Vaso getVasosPequeno()
        {
            return vasoPequeno;
        }

        public Azucarero getAzucarero()
        {
            return this.azucar;
        }
    }
}

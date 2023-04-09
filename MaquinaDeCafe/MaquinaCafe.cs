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
    }
}

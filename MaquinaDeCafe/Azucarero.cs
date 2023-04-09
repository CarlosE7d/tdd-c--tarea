using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeCafe
{
    public class Azucarero
    {
        public int cantidadDeAzucar;
        public Azucarero(int azucar)
        {
            this.cantidadDeAzucar = azucar;
        }

        public int getCantidadDeAzucar()
        {
            return this.cantidadDeAzucar;
        }

        public void giveAzucar(int v)
        {
            this.cantidadDeAzucar -= v;
        }

        public bool hasAzucar(int v)
        {
            if (cantidadDeAzucar >= v)
            {
                return true;
            }
            return false;
        }

        public void setCantidadDeAzucar(int cantAzucar)
        {
            this.cantidadDeAzucar = cantAzucar;
        }
    }
}

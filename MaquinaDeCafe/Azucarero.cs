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

        public bool hasAzucar(int v)
        {
            if (cantidadDeAzucar >= v)
            {
                return true;
            }
            return false;
        }
    }
}

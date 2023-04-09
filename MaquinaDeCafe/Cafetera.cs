using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeCafe
{
    public class Cafetera
    {
        public int cantidadDeCafe;

        public Cafetera(int cantCafe)
        {
            this.cantidadDeCafe = cantCafe;
        }

        public bool hasCafe(int v)
        {
            if(cantidadDeCafe >= v)
            {
                return true;
            }
            return false;
        }
    }
}

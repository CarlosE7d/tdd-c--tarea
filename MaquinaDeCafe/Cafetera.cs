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

        public int  getCantidadCafe()
        {
            return this.cantidadDeCafe;
        }

        public void giveCafe(int v)
        {
            this.cantidadDeCafe -= v;
        }

        public bool hasCafe(int v)
        {
            if(cantidadDeCafe >= v)
            {
                return true;
            }
            return false;
        }

        public void setCantidadDeCafe(int cantDeCafe)
        {
            this.cantidadDeCafe = cantDeCafe;
        }

        public int getCantidadDeCafe()
        {
            return this.cantidadDeCafe;
        }
    }
}

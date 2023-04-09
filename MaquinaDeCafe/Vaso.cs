using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeCafe
{
    public class Vaso
    {
        public int cantidadVaso;
        public int contenido;

        public Vaso(int cantidadVasos, int contenido)// Constructor
        {
            this.cantidadVaso = cantidadVasos;
            this.contenido = contenido;
        }

        public void setCantidadVasos(int cantidadVaso)
        {
            this.cantidadVaso = cantidadVaso;
        }

        public bool hasVasos(int v)
        {
            if (cantidadVaso >= v)
            {
                return true;
            }
            return false;
        }

        public void giveVasos(int v)
        {
            this.cantidadVaso -= v;
        }

        public int getCantidadVasos()
        {
            return this.cantidadVaso;
        }

        public int getContenido()
        {
            return this.contenido;
        }
    }


}

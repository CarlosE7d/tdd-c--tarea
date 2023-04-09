using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeCafe
{
    public class Dispensador
    {
        Cafetera cafetera;
        Vaso vasoPequeno;
        Vaso vasoMediano;
        Vaso vasoGrande;
        Azucarero azucarero;
        MaquinaCafe maquinaDeCafe;


        public Dispensador()
        {
            cafetera = new Cafetera(50);
            vasoPequeno = new Vaso(5, 10);
            vasoMediano = new Vaso(5, 20);
            vasoGrande = new Vaso(5, 30);
            azucarero = new Azucarero(20);
            maquinaDeCafe = new MaquinaCafe();
            maquinaDeCafe.setCafetera(cafetera);
            maquinaDeCafe.setVasosPequeno(vasoPequeno);
            maquinaDeCafe.setVasosMeadiano(vasoMediano);
            maquinaDeCafe.setVasosGrande(vasoGrande);
            maquinaDeCafe.setAzucarero(azucarero);

        }

        public void menuPrincipal()
        {                      

            try
            {
                Console.Clear();
                Console.WriteLine("---Seleccione el vaso que desea---\n1-Vaso Pequeño\n2-Vaso Meadiano\n3-Vaso Grande");
                int opc = Convert.ToInt32(Console.ReadLine());
                Vaso vaso = null;

                switch (opc)
                {
                    case (int)1:                        
                        vaso = maquinaDeCafe.getTipoDeVaso("pequeno");
                        break;

                    case (int)2:
                        vaso = maquinaDeCafe.getTipoDeVaso("mediano");                        
                        break;
                    case (int)3:
                        vaso = maquinaDeCafe.getTipoDeVaso("mediano");
                        break;
                }

                Console.WriteLine("---Seleccione la cantidad de vasos que desea---");
                int cantVasos = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("---Seleccione la cantidad de azucar que desea---");
                int cantAzucar = Convert.ToInt32(Console.ReadLine());


               string resultado = maquinaDeCafe.getVasoDeCafe(vaso, cantVasos, cantAzucar);
                Console.Clear();
                Console.WriteLine("****Su pedido fue****\n");
                Console.WriteLine("---Tipo De Vaso---");
                Console.WriteLine(vaso.ToString());
                Console.WriteLine("---Cantidad De Vasos---");
                Console.WriteLine(cantVasos);
                Console.WriteLine("---Cantidad De Azucar---");
                Console.WriteLine(cantAzucar);
                Console.WriteLine(resultado);
                Console.ReadLine();
                menuPrincipal();
            }
            catch
            {
                Console.WriteLine("Opción invalida");
                menuPrincipal();
            }

        }
    }
}

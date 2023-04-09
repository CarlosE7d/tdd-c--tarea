using System;

namespace MaquinaDeCafe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Carlos E. Mercedes Ramirez***\n       ---2020-10782---");
            Console.WriteLine("     ***Maquina De Cafe***");
            Console.WriteLine("      Presione para entrar");
            Console.ReadKey();
            Dispensador dispensador = new Dispensador();

            dispensador.menuPrincipal();
        }
    }
}
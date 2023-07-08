using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrón_de_diseño_Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AutoPrototype prototipoFiat = new FiatPrototype();
            AutoPrototype prototipoDS = new DSPrototype();
            AutoPrototype prototipoAlfaRomeo = new AlfaRomeoPrototype();

            AutoPrototype fiatPalio = prototipoFiat.Clone();
            fiatPalio.Modelo = "Palio Fire";
            fiatPalio.Color = "Negro";
            Console.WriteLine(fiatPalio.VerAuto());

            AutoPrototype fiatUno = prototipoFiat.Clone();
            fiatUno.Modelo = "Uno SRC";
            fiatUno.Color = "Blanco";
            Console.WriteLine(fiatUno.VerAuto());

            AutoPrototype ds3 = prototipoDS.Clone();
            ds3.Modelo = "3 Chic";
            ds3.Color = "Blanco";
            Console.WriteLine(ds3.VerAuto());

            AutoPrototype ds4 = prototipoDS.Clone();
            ds4.Modelo = "4 Sport";
            ds4.Color = "Negro";
            Console.WriteLine(ds4.VerAuto());

            AutoPrototype alfa145 = prototipoAlfaRomeo.Clone();
            alfa145.Modelo = "145";
            alfa145.Color = "Negro";
            Console.WriteLine(alfa145.VerAuto());

            AutoPrototype alfa146 = prototipoAlfaRomeo.Clone();
            alfa145.Modelo = "146";
            alfa145.Color = "Blanco";
            Console.WriteLine(alfa145.VerAuto());

            Console.ReadKey();

        }
    }
}

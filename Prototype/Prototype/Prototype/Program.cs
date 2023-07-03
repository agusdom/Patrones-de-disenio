using Prototype.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConfiguracion configuracionOriginal = new MyConfiguracion("Agusdom",123,true);
            MyConfiguracion configuracionClone = (MyConfiguracion) configuracionOriginal.Clone();
            var configuracionOriginal2 = configuracionOriginal;

            Console.WriteLine("Original");
            configuracionOriginal.toString();

            Console.WriteLine("Original 2");
            configuracionOriginal2.Setting1 = "Pablo";
            configuracionOriginal2.toString();

            Console.WriteLine("Cloned");
            configuracionClone.Setting1 = "Leonel";
            configuracionClone.toString();

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Palabra palabra = new Palabra("Hola Mundo!!!");
            foreach (var item in palabra)
            {
                Console.WriteLine(item);
            }

            //foreach (var item in "Hola Mundo!!!") { 
            //    Console.WriteLine(item);
            //}
            Console.ReadKey();
        }
    }
}

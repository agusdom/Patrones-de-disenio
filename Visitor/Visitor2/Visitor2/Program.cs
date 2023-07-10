﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pc1 = new ProductoClase1();
            pc1.Precio = 100;

            var pc2 = new ProductoClase2();
            pc2.Precio = 100;

            var iva = new OtroImpuesto();
            Console.WriteLine(String.Format("El total para Producto Clase 1 es:{0}",pc1.Aceptar(iva)));
            Console.WriteLine(String.Format("El total para Producto Clase 2 es:{0}", pc2.Aceptar(iva)));
            Console.ReadKey();
        }
    }
}

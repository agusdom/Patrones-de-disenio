using Chain_of_Responsibility.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var comprador = new Comprador();
            var gerente = new Gerente();
            var director = new Director();
            var directorGeneral = new DirectorGeneral();
            gerente.AgregarSiguiente(director);
            comprador.AgregarSiguiente(gerente);
            director.AgregarSiguiente(directorGeneral);
            var c = new Compra();
            double importe = 1;
            while (importe != 0)
            {
                Console.WriteLine("Ingrese el importe de la compra (0 para terminar)");
                importe = int.Parse(Console.ReadLine());
                c.Importe = importe;
                comprador.Procesar(c);
            }
            Console.ReadKey();
        }
    }
}

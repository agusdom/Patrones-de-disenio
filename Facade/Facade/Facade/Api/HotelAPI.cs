using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Api
{
    internal class HotelAPI
    {
        public void BuscarHoteles(String fechaEntrada, String fechaSalida, String origen, String destino)
        {
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("Hoteles encontrados");
            Console.WriteLine("Entrada:" + fechaEntrada + " Salida: " + fechaSalida);
            Console.WriteLine("Hotel A");
            Console.WriteLine("Hotel B");
            Console.WriteLine("Hotel C");
            Console.WriteLine("------------------------------------------------------------------");
        }
    }
}

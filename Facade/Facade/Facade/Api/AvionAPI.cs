﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Api
{
    internal class AvionAPI
    {
        public void BuscarVuelos(String fechaIda, String fechaVuelta,String origen,String destino)
        {
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("Vuelos encontrados para " + destino + " desde " + origen);
            Console.WriteLine("Fecha Ida: " + fechaIda + " Fecha Vuelta: " + fechaVuelta);
            Console.WriteLine("------------------------------------------------------------------");
        }
    }
}

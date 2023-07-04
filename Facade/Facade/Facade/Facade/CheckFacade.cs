using Facade.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Facade
{
    internal class CheckFacade
    {
        private AvionAPI avionAPI;
        private HotelAPI hotelAPI;

        public CheckFacade()
        {
            avionAPI = new AvionAPI();
            hotelAPI = new HotelAPI();
        }

        public void Buscar(String fechaIda,String fechaVuelta,String origen,String destino)
        {
            avionAPI.BuscarVuelos(fechaIda,fechaVuelta,origen,destino);
            hotelAPI.BuscarHoteles(fechaIda, fechaVuelta, origen, destino);
        }
    }
}

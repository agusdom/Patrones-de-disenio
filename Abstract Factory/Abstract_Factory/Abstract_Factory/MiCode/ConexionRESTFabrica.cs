using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract_Factory.Interfaz;
using Abstract_Factory.Implementacion;

namespace Abstract_Factory.MiCode
{
    internal class ConexionRESTFabrica : FabricaAbstractaRest
    {
        public IConexionREST getREST(string area)
        {
            if(area == null)
            {
                return new ConexionRESTNoArea();
            }
            if (area == "Compras")
            {
                return new ConexionRESTCompra();
            }
            else if (area == "Ventas")
            {

            }
            return new ConexionRESTVenta();
        }
    }
}

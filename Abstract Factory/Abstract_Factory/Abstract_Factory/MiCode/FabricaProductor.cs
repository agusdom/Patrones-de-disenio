using Abstract_Factory.Interfaz;
using Abstract_Factory.Implementacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.MiCode
{
    internal class FabricaProductor
    {
        public static FabricaAbstractaBD getFactoryBD(String tipoFabrica)
        {
          
                return new ConexionBDFabrica();
         
        }

    public static FabricaAbstractaRest getFactoryRest(String tipoFabrica)
    {
        return new ConexionRESTFabrica();
      
    }
}
}

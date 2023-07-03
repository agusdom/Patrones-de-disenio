using Fabrica_Abstracta.Interfaz;
using Fabrica_Abstracta.Implementacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica_Abstracta.MiCode
{
    internal class FabricaProductor
    {
        public static FabricaAbstracta getFactory(String tipoFabrica)
        {
            if (tipoFabrica == "BD")
            {
                return new ConexionBDFabrica();
            }else if (tipoFabrica == "REST")
            {
                return new ConexionRESTFabrica();
            }
            return null;
        }
    }
}

using Fabrica_Abstracta.Interfaz;
using Fabrica_Abstracta.MiCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica_Abstracta
{
    internal class App
    {
        static void Main(string[] args)
        {
            FabricaAbstracta fabricaBD = FabricaProductor.getFactory("BD");
            IConexionBD cxBD1 = fabricaBD.getBD("MySQL");

            cxBD1.Conectar();

            FabricaAbstracta fabricaREST = FabricaProductor.getFactory("REST");
            IConexionREST cxREST1 = fabricaREST.getREST("Compras");

            cxREST1.leerURL("https://www.youtube.com/watch?v=QmE-o5R7ZF4&list=PLvimn1Ins-41Uiugt1WbpyFo1XT1WOquL&index=4");

            Console.ReadKey();
        }
    }
}

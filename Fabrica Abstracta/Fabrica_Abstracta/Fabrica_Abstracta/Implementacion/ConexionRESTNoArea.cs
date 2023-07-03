using Fabrica_Abstracta.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica_Abstracta.Implementacion
{
    internal class ConexionRESTNoArea : IConexionREST
    {
        public void leerURL(string url)
        {
            Console.WriteLine("AREA NO ELEGIDA");
        }
    }
}

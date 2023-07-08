using Abstract_Factory.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Implementacion
{
    internal class ConexionRESTNoArea : IConexionREST
    {
        public void leerURL(string url)
        {
            Console.WriteLine("AREA NO ELEGIDA");
        }
    }
}

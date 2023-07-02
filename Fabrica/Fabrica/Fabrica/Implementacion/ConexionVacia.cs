using Fabrica.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica.Implementacion
{
    internal class ConexionVacia : IConexion
    {
        public void Conectar()
        {
            Console.WriteLine("NO SE ESPECIFICO EL PROVEEDOR");
        }

        public void Desconectar()
        {
            Console.WriteLine("NO SE ESPECIFICO EL PROVEEDOR");
        }
    }
}

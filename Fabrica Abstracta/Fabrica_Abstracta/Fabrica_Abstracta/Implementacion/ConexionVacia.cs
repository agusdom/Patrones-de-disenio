using Fabrica_Abstracta.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica_Abstracta.Implementacion
{
    internal class ConexionVacia : IConexionBD
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

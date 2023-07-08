using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.Interfaz;

namespace Factory
{
    internal class App
    {
        static void Main(string[] args)
        {
            ConexionFabrica fabrica = new ConexionFabrica();

            IConexion cx1 = fabrica.getConexion("Oracle");
            cx1.Conectar();
            cx1.Desconectar();

            IConexion cx2 = fabrica.getConexion("SQL");
            cx2.Conectar();
            cx2.Desconectar();

            IConexion cx3 = fabrica.getConexion("H2");
            cx3.Conectar();
            cx3.Desconectar();

            Console.ReadKey();
        }
    }
}

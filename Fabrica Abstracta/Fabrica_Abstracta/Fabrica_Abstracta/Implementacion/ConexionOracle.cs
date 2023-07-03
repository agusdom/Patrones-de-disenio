using Fabrica_Abstracta.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica_Abstracta.Implementacion
{
    internal class ConexionOracle : IConexionBD
    {
        private string host;
        private string puerto;
        private string usuario;
        private string contraseña;

        public ConexionOracle()
        {
            host = "localhost";
            puerto = "1521";
            usuario = "admin";
            contraseña = "123";
        }

        public void Conectar()
        {
            Console.WriteLine("Se conecto a Oracle");
        }

        public void Desconectar()
        {
            Console.WriteLine("Se desconecto a Oracle");
        }
    }
}

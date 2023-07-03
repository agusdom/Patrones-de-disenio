using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fabrica_Abstracta.Interfaz;

namespace Fabrica_Abstracta.Implementacion
{
    public class ConexionMySQL : IConexionBD
    {
        private string host;
        private string puerto;
        private string usuario;
        private string contraseña;

        public ConexionMySQL()
        {
            host = "localhost";
            puerto = "3306";
            usuario = "root";
            contraseña = "123";
        }

        public void Conectar()
        {
            Console.WriteLine("Se conecto a MySQL");
        }

        public void Desconectar()
        {
            Console.WriteLine("Se desconecto a MySQL");
        }
    }
}

﻿using Fabrica_Abstracta.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica_Abstracta.Implementacion
{
    internal class ConexionSQLServer : IConexionBD
    {
        private string host;
        private string puerto;
        private string usuario;
        private string contraseña;

        public ConexionSQLServer()
        {
            host = "localhost";
            puerto = "1433";
            usuario = "root";
            contraseña = "123";
        }

        public void Conectar()
        {
            Console.WriteLine("Se conecto a SQLServer");
        }

        public void Desconectar()
        {
            Console.WriteLine("Se desconecto a SQLServer");
        }
    }
}

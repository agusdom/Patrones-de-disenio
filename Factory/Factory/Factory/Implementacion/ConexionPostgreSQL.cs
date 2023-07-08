﻿using Factory.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Implementacion
{
    internal class ConexionPostgreSQL : IConexion
    {
        private string host;
        private string puerto;
        private string usuario;
        private string contraseña;

        public ConexionPostgreSQL()
        {
            host = "localhost";
            puerto = "5433";
            usuario = "postgres";
            contraseña = "123";
        }

        public void Conectar()
        {
            Console.WriteLine("Se conecto a PostgreSQL");
        }

        public void Desconectar()
        {
            Console.WriteLine("Se desconecto a PostgreSQL");
        }
    }
}

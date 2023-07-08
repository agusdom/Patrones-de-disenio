using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract_Factory.Implementacion;
using Abstract_Factory.Interfaz;

namespace Abstract_Factory

{
    internal class ConexionBDFabrica : FabricaAbstractaBD
    {
        public IConexionBD getBD(String motor)
        {
            if (motor == null)
            {
                return new ConexionVacia();
            }
            if(motor == "MySQL")
            {
                return new ConexionMySQL();
            }
            else if (motor == "Oracle")
            {
                return new ConexionOracle();
            }
            else if (motor == "Postgre")
            {
                return new ConexionPostgreSQL();
            }
            else if (motor == "SQL")
            {
                return new ConexionSQLServer();
            }

            return new ConexionVacia();
        }

    }
}

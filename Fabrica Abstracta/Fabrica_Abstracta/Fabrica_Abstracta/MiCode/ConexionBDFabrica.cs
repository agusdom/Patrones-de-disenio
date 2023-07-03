using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fabrica_Abstracta.Implementacion;
using Fabrica_Abstracta.Interfaz;

namespace Fabrica_Abstracta

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

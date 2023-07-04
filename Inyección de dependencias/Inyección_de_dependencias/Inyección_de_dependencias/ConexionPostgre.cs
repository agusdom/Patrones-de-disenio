using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inyección_de_dependencias
{
    public class ConexionPostgre : IConexion
    {
        private String usuario;
        private String clave;
        private String host;

        public ConexionPostgre(String usuario,String clave,String host)
        {
            this.usuario = usuario;
            this.clave = clave;
            this.host = host;
        }

        public void Conectar()
        {
            Console.WriteLine("Conectando a Postgre");
        }
    }
}

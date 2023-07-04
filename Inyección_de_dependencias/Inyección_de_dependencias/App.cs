using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inyección_de_dependencias
{
    public class App
    {
        public static void Main(string[] args)
        {
            IConexion cx = new ConexionPostgre("mitocode","7482","192.168.1.1");
            
            IConexion cx2 = new ConexionMySQL("mitocode", "7482", "localhost");

            PersonaDAO dao = new PersonaDAOImpl();

            dao.setConexion(cx2);

            dao.ListarTodos();

            Console.ReadKey();
        }
    }
}

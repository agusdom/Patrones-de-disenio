using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instanciación por constructor prohíbido por ser "privado"
            //Conexion c = new Conexion();
            Conexion c = Conexion.getInstancia();
            c.conectar();
            c.desconectar();

            bool rspt = c is Conexion;
            Console.WriteLine(rspt);

            Console.ReadKey();
        }
    }

    public class Conexion
    {
        //Declacion
        private static Conexion instancia;
        //private static Conexion instancia = new Conexion();
        //Para evitar instancia mediante operador "new"
        private Conexion() { 
        
        }
        /*
         * Para obtener la instancia unicamente por este metodo.
         * Notase la palabra reservada "static" hace posible el acceso mediante Clase.metodo
         */
        public static Conexion getInstancia()
        {
            if (instancia == null)
            {
                instancia = new Conexion(); 
            }
            return instancia;
        }
        //Metodo prueba
        public void conectar() {
            Console.WriteLine("Me conecte a la BD");
        }
        //Metodo prueba
        public void desconectar()
        {
            Console.WriteLine("Me desconecte a la BD");
        }
    }
}

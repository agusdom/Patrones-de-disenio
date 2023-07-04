using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inyección_de_dependencias
{
    public class PersonaDAOImpl : PersonaDAO
    {
        private IConexion conexion;

        /* public PersonaDAOImpl(IConexion conexion)
         {
             this.conexion = conexion;
         }*/

        public void setConexion(IConexion conexion)
        {
            this.conexion = conexion;
        }

        public void Actualizar(Persona persona)
        {
            Console.WriteLine("Persona " + persona.getNombre() + " actualizada.");
        }

        public void Eliminar(int id)
        {
            Console.WriteLine("Id: " + id + " eliminado.");
        }

        public Persona LeerPorId(int id)
        {
            return null;
        }

        public List<Persona> ListarTodos()
        {
            this.conexion.Conectar();
            Console.WriteLine("Listando.......");
            return null;
        }

        public void MostrarNombre(Persona persona)
        {
            Console.WriteLine("Mi nombre es: " + persona.getNombre());
        }

        public void Registrar(Persona persona)
        {
            Console.WriteLine("Persona " + persona.getNombre() + " registrada.");
        }
    }
}

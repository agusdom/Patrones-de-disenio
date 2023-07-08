using Dao.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao.Dao
{
    public class PersonaDAOImpl : PersonaDAO
    {

        public List<Persona> ListarTodos()
        {
            List<Persona> lista = new List<Persona>();
            Persona per = new Persona();
            per.setId(1);
            per.setNombre("Mito");
            
            lista.Add(per);

            per = new Persona();
            per.setId(2);
            per.setNombre("Code");

            lista.Add(per);

            return lista;
        }

        public void Registrar(Persona persona)
        {
            Console.WriteLine("Persona " + persona.getNombre() + " registrada.");
        }

        public void Actualizar(Persona persona)
        {
            Console.WriteLine("Persona " + persona.getNombre() + " actualizada.");
        }

        public void Eliminar(int id)
        {
            Console.WriteLine("Id:" + id + " eliminado.");
        }

        public Persona LeerPorId(int id)
        {
            return null;
        }

        public void MostrarNombre(Persona persona)
        {
            Console.WriteLine("Mi nombre es:" + persona.getNombre());
        }
    }
}

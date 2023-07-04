using Dao.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao.Dao
{
    public class MedicoDAOImpl : MedicoDAO
    {
        public List<Medico> ListarTodos()
        {
            List<Medico> lista = new List<Medico>();
            Medico doc = new Medico();
            doc.setId(1);
            doc.setNombre("Agustin Dominguez");

            lista.Add(doc);

            return lista;
        }

        public void Registrar(Medico medico)
        {
            Console.WriteLine("Medico " + medico.getNombre() + " registrado.");
        }

        public void Actualizar(Medico medico)
        {
            Console.WriteLine("Medico " + medico.getNombre() + " actualizado.");
        }

        public void Eliminar(int id)
        {
            Console.WriteLine("Id:" + id + " eliminado.");
        }

        public Medico LeerPorId(int id)
        {
            return null;
        }

        public void Curar(Medico medico)
        {
            Console.WriteLine("El medico " + medico.getNombre() + " esta curando.");
        }
    }
}
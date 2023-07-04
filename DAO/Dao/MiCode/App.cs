using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dao.Dao;
using Dao.Model;
namespace Dao
{
    public class App
    {
        static void Main(string[] args)
        {
            CRUD<Persona> dao = new PersonaDAOImpl();
            dao.ListarTodos().ToList().ForEach(x => Console.WriteLine(x.getNombre()));

            Persona per = new Persona();
            per.setNombre("MitoCode");
            dao.Registrar(per);
            Console.ReadLine();
        }
    }
}

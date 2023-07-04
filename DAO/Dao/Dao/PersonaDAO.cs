using Dao.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dao.Model;
namespace Dao.Dao
{
    public interface PersonaDAO : CRUD<Persona>
    {
        void MostrarNombre(Persona persona);

    }
}

using Dao.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao.Dao
{
    public interface MedicoDAO : CRUD<Medico>
    {
        void Curar(Medico medico);
    }
}

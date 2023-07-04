using Dao.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao.Dao
{
    public interface CRUD<T>
    {
        List<T> ListarTodos();
        T LeerPorId(int id);
        void Registrar(T t);
        void Actualizar(T t);
        void Eliminar(int id);
    }
}

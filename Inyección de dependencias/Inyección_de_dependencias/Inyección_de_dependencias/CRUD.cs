using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inyección_de_dependencias
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

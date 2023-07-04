using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inyección_de_dependencias
{
    public interface PersonaDAO : CRUD<Persona>
    {
        void MostrarNombre(Persona persona);
        void setConexion(IConexion conexion);

    }
}

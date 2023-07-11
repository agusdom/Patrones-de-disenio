using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public abstract class Componente
    {
        String _nombre;

        public Componente(String nombre)
        {
            _nombre = nombre;
        }

        public String Nombre { get { return _nombre; } }
        public abstract void AgregarHijo(Componente c);
        public abstract IList<Componente> ObtenerHijos();
        public abstract int ObtenerTamaño { get; }

    }
}

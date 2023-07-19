using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public abstract class Agregado
    {
        protected String _descripcion;

        public String Descripcion { get { return _descripcion; } }
    }

    public class Oregano : Agregado
    {
        public Oregano()
        {
            _descripcion = "Oregano fresco";
        }
    }

    public class Anchoas : Agregado
    {
        public Anchoas()
        {
            _descripcion = "Anchoas en aceite";
        }
    }

    public class Berenjenas : Agregado
    {
        public Berenjenas()
        {
            _descripcion = "Berenjenas sin calorías";
        }
    }
}

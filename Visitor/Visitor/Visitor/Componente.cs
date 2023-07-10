using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public abstract class Componente
    {
        String _serial;

        public Componente(String serial)
        {
            _serial = serial;
        }

        public String Serial
        {
            get { return _serial; }
        }

        public void Aceptar(IVisitor visitor)
        {
            visitor.Visitar(_serial);
        }
    }
}

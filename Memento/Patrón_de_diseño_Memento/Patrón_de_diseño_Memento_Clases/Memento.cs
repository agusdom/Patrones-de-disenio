using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrón_de_diseño_Memento_Clases
{
    public class Memento
    {
        private String _estado;

        public Memento() { }

        public Memento(String estado)
        {
            _estado = estado;
        }

        public String Estado{
            get
            {
                return _estado;
            }
        }
    }
}

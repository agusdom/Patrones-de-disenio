using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Memento
{
    public class Juego
    {
        protected String nombre;
        protected int checkpoint;

        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }

        public void setCheckpoint(int checkpoint)
        {
            this.checkpoint = checkpoint;
        }

        public String ToString()
        {
            return $"Nombre:{nombre},CheckPoint:{checkpoint}";
        }
    }
}

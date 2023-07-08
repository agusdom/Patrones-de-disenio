using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Memento
{
    public class Memento
    {
        public Juego estado;

        public Memento(Juego estado)
        {
            this.estado = estado;
        }

        public Juego getEstado()
        {
            return estado;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Memento { 
    public class Originator
    {
        private Juego estado;

        public void setEstado(Juego estado)
        {
            this.estado = estado;
        }

        public Juego getEstado()
        {
            return estado;
        }

        public Memento Guardar()
        {
            return new Memento(estado);
        }

        public void Restaurar(Memento m)
        {
            this.estado = m.getEstado();
        }
    }
}

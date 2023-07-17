using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public abstract class Chat
    {
        protected List<Mensaje> _mensajes;

        public Chat()
        {
            _mensajes = new List<Mensaje>();
        }

        public Mensaje[] Mensajes
        {
            get
            {
                return _mensajes.ToArray();
            }
        }

        public abstract void Enviar(String _mensaje,Usuario _para,Usuario _de);
        public abstract void Registrar(Usuario _usuario);
    }
}

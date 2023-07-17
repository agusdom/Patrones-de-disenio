using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public abstract class Usuario
    {
        List<Mensaje> _mensajes;
        String _nombre;

        public Usuario(String nombre)
        {
            _nombre = nombre;
            _mensajes = new List<Mensaje>();
        }

        public Mensaje[] Mensajes
        {
            get
            {
                return _mensajes.ToArray();
            }
        }

        public String Nombre
        {
            get
            {
                return _nombre;
            }
        }

        public override string ToString()
        {
            return _nombre;
        }

        public Chat Chat { get; set; }

        public void Enviar(String _mensaje,Usuario _para)
        {
            Chat.Enviar(_mensaje,_para,this);
        }

        public void Recibir(Mensaje msg)
        {
            _mensajes.Add(msg);
        }

    }
}

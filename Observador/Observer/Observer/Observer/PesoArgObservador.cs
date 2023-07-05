using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Observer
{
    public class PesoArgObservador : Observador
    {
        private double valorCambio = 252;

        public PesoArgObservador(Subject sujeto)
        {
            this.sujeto = sujeto;
            this.sujeto.Agregar(this);
        }

        public override void Actualizar()
        {
            Console.WriteLine("ARG:" + (sujeto.getEstado() * valorCambio));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Observer
{
    public class PesoMxObservador : Observador
    {
        private double valorCambio = 17.16;

        public PesoMxObservador(Subject sujeto)
        {
            this.sujeto = sujeto;
            this.sujeto.Agregar(this);
        }

        public override void Actualizar()
        {
            Console.WriteLine("MEX:" + (sujeto.getEstado() * valorCambio));
        }
    }
}

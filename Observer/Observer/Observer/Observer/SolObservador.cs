using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Observer
{
    public class SolObservador : Observador
    {
        private double valorCambio = 3.61;

        public SolObservador(Subject sujeto) { 
            this.sujeto = sujeto;
            this.sujeto.Agregar(this);
        }

        public override void Actualizar()
        {
            Console.WriteLine("PEN:" + (sujeto.getEstado() * valorCambio));
        }
    }
}

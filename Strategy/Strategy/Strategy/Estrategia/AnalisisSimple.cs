using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Estrategia
{
    public abstract class AnalisisSimple : IEstrategia
    {
        public void Analizar()
        {
            Iniciar();
            SaltaZip();
            Detener();
        }

        protected abstract void Iniciar();

        protected abstract void SaltaZip();

        protected abstract void Detener();
    }
}

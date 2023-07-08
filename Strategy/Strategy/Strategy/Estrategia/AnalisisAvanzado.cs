using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Estrategia
{
    public abstract class AnalisisAvanzado : IEstrategia
    {
        public void Analizar()
        {
            Iniciar();
            AnalizarMemoria();
            AnalizarKeyLoggers();
            AnalizarRootKits();
            DescomprimirZip();
            Detener();
        }

        protected abstract void Iniciar();

        protected abstract void AnalizarMemoria();

        protected abstract void AnalizarKeyLoggers();

        protected abstract void AnalizarRootKits();

        protected abstract void DescomprimirZip();

        protected abstract void Detener();
    }
}

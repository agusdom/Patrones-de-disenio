using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    public abstract class Credito : Verificaciones
    {
        public Credito(Cliente c) { 
            _cliente = c;
        }

        protected abstract override String VerificarAcciones();
        protected abstract override String VerificarBalance();
        protected abstract override String VerificarIngresos();
        protected abstract override String VerificarCreditos(); 
    }
}

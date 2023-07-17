using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    public abstract class Verificaciones
    {
        protected Cliente _cliente;

        public String[] Verificar()
        {
            var msg = new List<String>();

            msg.Add($"Verificando crédito para {_cliente.Nombre}");
            msg.Add(VerificarAcciones());
            msg.Add(VerificarBalance());
            msg.Add(VerificarCreditos());
            msg.Add(VerificarIngresos());

            return msg.ToArray();
        }

        protected abstract String VerificarAcciones();
        protected abstract String VerificarBalance();
        protected abstract String VerificarIngresos();
        protected abstract String VerificarCreditos();
    }
}

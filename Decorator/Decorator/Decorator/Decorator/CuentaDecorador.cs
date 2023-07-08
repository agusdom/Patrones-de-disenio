using Decorator.Interfaz;
using Decorator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorator
{
    public class CuentaDecorador : ICuentaBancaria
    {
        protected ICuentaBancaria cuentaDecorada;

        public CuentaDecorador(ICuentaBancaria cuentaDecorada)
        {
            this.cuentaDecorada = cuentaDecorada;
        }

        public virtual void AbrirCuenta(Cuenta c)
        {
            this.cuentaDecorada.AbrirCuenta(c);
        }

    }
}

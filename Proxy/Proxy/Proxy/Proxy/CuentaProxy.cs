using Proxy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proxy.Implementacion;
using System.Threading;

namespace Proxy.Proxy
{
    public class CuentaProxy : ICuenta
    {
        private ICuenta cuentaReal;

        public CuentaProxy(ICuenta cuentaReal)
        {
            this.cuentaReal = cuentaReal;
        }

        public Cuenta DepositarDinero(Cuenta cuenta, double monto)
        {
            if (cuentaReal == null)
            {
                cuentaReal = new CuentaBancoAImpl();
                return cuentaReal.DepositarDinero(cuenta, monto);
            }
            else
            {
                return cuentaReal.DepositarDinero(cuenta, monto);
            }
        }

        public void MostrarSaldo(Cuenta cuenta)
        {
            if (cuentaReal == null)
            {
                cuentaReal = new CuentaBancoAImpl();
                cuentaReal.MostrarSaldo(cuenta);
            }
            else
            {
                cuentaReal.MostrarSaldo(cuenta);
            }
        }

        public Cuenta RetirarDinero(Cuenta cuenta, double monto)
        {
           if (cuentaReal == null)
            {
                cuentaReal = new CuentaBancoAImpl();
                return cuentaReal.RetirarDinero(cuenta,monto);
            }
            else
            {
                return cuentaReal.RetirarDinero(cuenta,monto);
            }
        }
    }
}

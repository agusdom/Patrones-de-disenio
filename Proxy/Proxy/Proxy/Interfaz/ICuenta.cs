using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Model
{
    public  interface ICuenta
    {
        Cuenta RetirarDinero(Cuenta cuenta,double monto);
        Cuenta DepositarDinero(Cuenta cuenta, double monto);
        void MostrarSaldo(Cuenta cuenta);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Commands
{
    public class DepositarImpl : IOperacion
    {
        private Cuenta cuenta;
        private double monto;

        public DepositarImpl(Cuenta cuenta, double monto)
        {
            this.cuenta = cuenta;
            this.monto = monto;
        }

        public void Execute()
        {
            this.cuenta.Depositar(this.monto);
        }
    }
}

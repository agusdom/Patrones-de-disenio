using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Commands
{
    public class Cuenta
    {
        private int id;
        private double saldo;

        public Cuenta(int id, double saldo)
        {
            this.id = id;
            this.saldo = saldo;
        }

        public void Retirar(double monto)
        {
            this.saldo = this.saldo - monto;
            Console.WriteLine("[Comando Retirar] Cuenta:" + id + " Saldo:" + this.saldo);
        }

        public void Depositar(double monto)
        {
            this.saldo = this.saldo + monto;
            Console.WriteLine("[Comando Depositar] Cuenta:" + id + " Saldo:" + this.saldo);
        }
    }
}

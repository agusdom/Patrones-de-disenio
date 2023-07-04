using Command.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class App
    {
        static void Main(string[] args)
        {
            Cuenta cuenta = new Cuenta(1,200);

            DepositarImpl opDepositar = new DepositarImpl(cuenta,100);
            RetirarImpl opRetirar = new RetirarImpl(cuenta,50);

            Invoker ivk = new Invoker();
            ivk.RecibirOperacion(opDepositar);
            ivk.RecibirOperacion(opRetirar);

            ivk.RealizarOperacion();

            Console.ReadKey();
        }
    }
}

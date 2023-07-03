using Proxy.Implementacion;
using Proxy.Model;
using Proxy.Proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    internal class App
    {
        static void Main(string[] args)
        {
            Cuenta c = new Cuenta(1,"MiCode",100);

            ICuenta cuenta = new CuentaProxy(new CuentaBancoBImpl());
            cuenta.MostrarSaldo(c);
            c = cuenta.DepositarDinero(c,50);
            c = cuenta.RetirarDinero(c,20);
            cuenta.MostrarSaldo(c);
            Console.ReadKey();
        }
    }
}

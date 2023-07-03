using Proxy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Implementacion
{
    public class CuentaBancoAImpl : ICuenta
    {
        public Cuenta DepositarDinero(Cuenta cuenta, double monto)
        {
            Console.WriteLine("----Cuenta Proxy - Depositar Dinero----");
            double saldoActual = cuenta.getSaldoInicial() + monto;
            cuenta.setSaldoInicial(saldoActual);
            Console.WriteLine("Saldo actual:" + cuenta.getSaldoInicial());
            return cuenta;
        }

        public void MostrarSaldo(Cuenta cuenta)
        {
            Console.WriteLine("----Cuenta Proxy - Mostrar Dinero----");
            Console.WriteLine("Saldo actual:" + cuenta.getSaldoInicial());
        }

        public Cuenta RetirarDinero(Cuenta cuenta, double monto)
        {
            Console.WriteLine("----Cuenta Proxy - Retirar Dinero----");
            double saldoActual = cuenta.getSaldoInicial() - monto;
            cuenta.setSaldoInicial(saldoActual);
            Console.WriteLine("Saldo actual:" + cuenta.getSaldoInicial());
            return cuenta;
        }
    }
}

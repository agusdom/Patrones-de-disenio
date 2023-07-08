using Decorator.Decorator;
using Decorator.Interfaz;
using Decorator.InterfazImp;
using Decorator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class App
    {
        static void Main(string[] args)
        {
            Cuenta c = new Cuenta(1,"MitoCode");

            ICuentaBancaria cuenta = new CuentaAhorro();
            ICuentaBancaria cuentaBlindada = new BlindajeDecorador(cuenta);

            cuentaBlindada.AbrirCuenta(c);

            Console.ReadKey();
        }
    }
}

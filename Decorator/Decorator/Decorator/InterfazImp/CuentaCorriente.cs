using Decorator.Interfaz;
using Decorator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.InterfazImp
{
    public class CuentaCorriente : ICuentaBancaria
    {
        public void AbrirCuenta(Cuenta c)
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("Se abrió una cuenta corrienta.");
            Console.WriteLine("Cliente: " + c.getCliente());
        }
    }
}

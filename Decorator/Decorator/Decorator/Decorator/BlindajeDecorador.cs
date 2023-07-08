using Decorator.Interfaz;
using Decorator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorator
{
    public class BlindajeDecorador : CuentaDecorador
    {
        public BlindajeDecorador(ICuentaBancaria cuentaDecorada) : base(cuentaDecorada)
        {
            
        }


        public override void AbrirCuenta(Cuenta c)
        {
            base.AbrirCuenta(c);
            AgregarBlindaje(c);
        }

        public void AgregarBlindaje(Cuenta c)
        {
            Console.WriteLine("Se agrego blindaje a la cuenta del cliente " + c.getCliente());
        }

    }
}

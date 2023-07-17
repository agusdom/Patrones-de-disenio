using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    public class CreditoPersonal : Credito
    {

        public CreditoPersonal(Cliente c) : base(c) { }
        protected override string VerificarAcciones()
        {
            return "Verificando acciones para asignar un crédito personal";
        }

        protected override string VerificarBalance()
        {
            return "Verificando balance bancario para un prestamo personal";
        }

        protected override string VerificarCreditos()
        {
            return "Verificando otros creditos para un prestamo personal";
        }

        protected override string VerificarIngresos()
        {
            return "Verificando ingresos para asignar un crédito personal";
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    public class CreditoHipotecario : Credito
    {

        public CreditoHipotecario(Cliente c) : base(c) { }
        protected override string VerificarAcciones()
        {
            return "Verificando acciones para asignar un crédito hipotecario";
        }

        protected override string VerificarBalance()
        {
            return "Verificando balance bancario para un prestamo hipotecario";
        }

        protected override string VerificarCreditos()
        {
            return "Verificando otros creditos para un prestamo hipotecario";
        }

        protected override string VerificarIngresos()
        {
            return "Verificando ingresos para asignar un crédito hipotecario";
        }
    }
}

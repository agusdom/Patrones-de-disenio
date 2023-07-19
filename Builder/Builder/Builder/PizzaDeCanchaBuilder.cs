using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class PizzaDeCanchaBuilder : PizzaBuilder
    {

        public PizzaDeCanchaBuilder()
        {
            _descripcion = "Pizza de Cancha";
        }

        public override Agregado BuildAgregado()
        {
            return new Anchoas();
        }

        public override Salsa BuildSalsa()
        {
            return new AjoAlOleo();
        }

        protected override Masa BuildMasa()
        {
            return new Integral();
        }
    }
}

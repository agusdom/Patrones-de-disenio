using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor2
{
    public class OtroImpuesto : IVisitor
    {
        public double Visitar(ProductoClase1 p)
        {
            return p.Precio * 1.4;
        }

        public double Visitar(ProductoClase2 p)
        {
            return p.Precio * 0.8;
        }
    }
    public class IVA : IVisitor
    {
        private double impuestoClase1 = 1.21d;
        private double impuestoClase2 = 1.105d;

        public double Visitar(ProductoClase1 p)
        {
            return p.Precio * impuestoClase1;
        }

        public double Visitar(ProductoClase2 p)
        {
            return p.Precio * impuestoClase2;
        }
    }
}

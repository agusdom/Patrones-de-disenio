using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor2
{
    public interface IVisitor
    {
        double Visitar(ProductoClase1 p);
        double Visitar(ProductoClase2 p);
    }
}

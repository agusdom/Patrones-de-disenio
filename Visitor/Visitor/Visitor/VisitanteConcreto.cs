using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class VisitanteConcreto : IVisitor
    {
        public void Visitar(String serie)
        {
            Console.WriteLine(String.Format("s/n {0}", serie));
        }

        
    }

    public class VisitanteConcreto2 : IVisitor
    {
        public void Visitar(String serie)
        {
            Console.WriteLine(String.Format("El numero de serie es:{0}", serie));
        }
    }
}

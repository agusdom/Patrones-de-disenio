using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrón_de_diseño_Prototype
{
    public class DSPrototype : AutoPrototype
    {
        public override AutoPrototype Clone()
        {
            return (DSPrototype)this.MemberwiseClone();
        }

        public override string VerAuto()
        {
            return $"DS {_modelo},color {_color}";
        }
    }
}

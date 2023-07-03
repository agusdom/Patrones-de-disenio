using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrón_de_diseño_Prototype
{
    public class FiatPrototype : AutoPrototype
    {
        public override AutoPrototype Clone()
        {
            return (FiatPrototype) this.MemberwiseClone();
        }

        public override string VerAuto()
        {
            return $"Fiat {_modelo},color {_color}";
        }
    }
}

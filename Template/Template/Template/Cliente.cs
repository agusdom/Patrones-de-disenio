using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    public class Cliente
    {
        public String Nombre { get; set;}

        public override string ToString()
        {
            return Nombre;
        }
    }
}

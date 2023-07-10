using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Ejemplo
{
    public class Item
    {
        public String Nombre { get; set; }

        public Item(String _nom)
        {
            Nombre = _nom;
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}

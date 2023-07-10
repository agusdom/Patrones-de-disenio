using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator2
{
    public class Palabra : IEnumerable
    {
        String _palabra;

        public Palabra(String palabra)
        {
            _palabra = palabra;
        }

        public IEnumerator GetEnumerator()
        {
            return new PalabraIterator(_palabra);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Ejemplo
{
    public class ConcreteCollection : Collection
    {
        private List<Item> _listaItems = new List<Item>();
        private Item _item;
        private int _posicion;

        public override IteratorEjemplo CreateIterator()
        {
            return new ConcreteCollectionEjemplo(this);
        }
        public override void Agregar(Item item)
        {
            _listaItems.Add(item);
        }

        public override int Count()
        {
            return _listaItems.Count;
        }

        public override Item Index(int _index)
        {
            _item = _listaItems[_index];
            _posicion = _index;
            return _item;
        }

        public override int Posicion()
        {
            return _posicion;
        }
    }
}

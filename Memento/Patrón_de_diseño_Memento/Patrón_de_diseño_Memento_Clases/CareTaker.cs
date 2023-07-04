using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrón_de_diseño_Memento_Clases
{
    public class CareTaker
    {
        private List<Memento> mementoList = new List<Memento>();

        public void Add(Memento m)
        {
            mementoList.Add(m);
        }

        public Memento GetMemento(int index) { 
         return mementoList[index];
        }
    }
}

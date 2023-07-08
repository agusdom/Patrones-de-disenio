using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Memento
{
    public class Caretaker
    {
        private ArrayList mementos = new ArrayList();

        public void addMemento(Memento m)
        {
            mementos.Add(m);
        }

        public Memento getMemento(int index)
        {
            return (Memento)mementos[index];
        }
    }
}

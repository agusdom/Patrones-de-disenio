using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patrón_de_diseño_Memento_Clases;

namespace Patrón_de_diseño_Memento
{
    public class Program
    {
        static CareTaker caretaker = new CareTaker();
        static void Main(string[] args)
        {
            var p = new Persona();
            p.Nombre = "Pepe";
            caretaker.Add(p.SaveToMemento());
            p.Nombre = "Pepe1";
            caretaker.Add(p.SaveToMemento()); 
            p.Nombre = "Pepe2";
            caretaker.Add(p.SaveToMemento());

            Memento m1 = caretaker.GetMemento(0);
            Console.WriteLine("Viendo memento 1:" + m1.Estado);
            Console.WriteLine("Viendo memento 2:" + caretaker.GetMemento(1).Estado);
            Console.WriteLine("Viendo memento 3:" + caretaker.GetMemento(2).Estado);
            p.RestoreToMemento(m1);
            Console.ReadKey();
        }
    }
}

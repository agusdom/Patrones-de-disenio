using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrón_de_diseño_Memento_Clases
{
    public class Persona
    {
        public String Nombre { get; set; }

        public Memento SaveToMemento()
        {
            Console.WriteLine("Originator: Guardando memento para " +  Nombre);
            return new Memento();
        }

        public void RestoreToMemento(Memento m)
        {
            Nombre = m.Estado;
            Console.WriteLine("Originator: Recuperando memento para " + Nombre);
        }
    }
}

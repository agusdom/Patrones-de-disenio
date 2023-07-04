using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Memento.Memento;

namespace Memento
{
    public class App
    {
        static void Main(string[] args)
        {
            String nombreJuego = "Crash Bandicoot";

            Juego juego = new Juego();
            juego.setNombre(nombreJuego);
            juego.setCheckpoint(1);

            Caretaker caretaker = new Caretaker();
            Originator originator = new Originator();

            juego = new Juego();
            juego.setNombre(nombreJuego);
            juego.setCheckpoint(2);
            originator.setEstado(juego);

            juego = new Juego();
            juego.setNombre(nombreJuego);
            juego.setCheckpoint(3);
            originator.setEstado(juego);

            caretaker.addMemento(originator.Guardar()); //ESTADO POSICIÓN 0

            juego = new Juego();
            juego.setNombre(nombreJuego);
            juego.setCheckpoint(4);

            originator.setEstado(juego);
            caretaker.addMemento(originator.Guardar()); //ESTADO POSICIÓN 1

            juego = new Juego();
            juego.setNombre(nombreJuego);
            juego.setCheckpoint(5);

            originator.setEstado(juego);
            caretaker.addMemento(originator.Guardar()); //ESTADO POSICIÓN 2

            originator.Restaurar(caretaker.getMemento(2));

            juego = originator.getEstado();
            Console.WriteLine(juego.ToString());

            Console.ReadKey();
        }
    }
}

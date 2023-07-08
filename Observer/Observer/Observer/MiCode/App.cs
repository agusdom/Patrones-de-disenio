using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Observer.Observer;

namespace Observer
{
    public class App
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject();

            new SolObservador(subject);
            new PesoArgObservador(subject);
            new PesoMxObservador(subject);

            Console.WriteLine("Si desea cambiar 10 dolares obtendra :  ");
            subject.setEstado(10);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Si desea cambiar 100 dolares obtendra : ");
            subject.setEstado(100);

            Console.ReadLine();

        }
    }
}

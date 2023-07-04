using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facade.Facade;

namespace Facade
{
    internal class App
    {
        static void Main(string[] args)
        {
            CheckFacade cliente1 = new CheckFacade();
            cliente1.Buscar("02/07/2018", "08/07/2018","Lima","Cancún");

            CheckFacade cliente2 = new CheckFacade();
            cliente2.Buscar("02/07/2018", "08/07/2018", "Lima", "Quito");

            Console.ReadKey();
        }
    }
}

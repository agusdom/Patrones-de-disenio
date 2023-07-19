using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class Program
    {
        static void Main(string[] args)
        {
            Switch _switch = new Switch();

            _switch.Presionar();
            _switch.Presionar();
            _switch.Presionar();
            _switch.Presionar();
            _switch.Presionar();
            _switch.Presionar();

            Console.ReadKey();
        }
    }
}

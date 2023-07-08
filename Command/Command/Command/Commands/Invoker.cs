using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Commands
{
    public class Invoker
    {
        private List<IOperacion> operaciones = new List<IOperacion>();

        public void RecibirOperacion(IOperacion operacion)
        {
            this.operaciones.Add(operacion);
        }

        public void RealizarOperacion()
        {
            foreach(IOperacion x in operaciones)
            {
                x.Execute();
            }
          this.operaciones.Clear();
        }
    }
}

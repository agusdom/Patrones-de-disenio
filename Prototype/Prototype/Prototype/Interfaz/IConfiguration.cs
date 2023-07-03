using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Interfaz
{
    public interface IConfiguration
    {
        IConfiguration Clone();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Interfaz
{
    public interface IConexionBD
    {
        void Conectar();
        void Desconectar();
    }
}

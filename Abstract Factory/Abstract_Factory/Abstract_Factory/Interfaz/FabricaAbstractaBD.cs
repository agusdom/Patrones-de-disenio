﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Interfaz
{
    internal interface FabricaAbstractaBD
    {
        IConexionBD getBD(String motor);
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica_Abstracta.Interfaz
{
    internal interface FabricaAbstractaRest
    {
        IConexionREST getREST(String area);
    }
}

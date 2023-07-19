﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class StandBy : Estado
    {
        public override void ControlarEstado(Switch sw)
        {
            sw.DefinirEstado(new Encendido());
        }

        public override string Describir()
        {
            return "Switch en Stand By";
        }
    }
}

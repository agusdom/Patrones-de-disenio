﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public abstract class Masa
    {
        protected String _descripcion;

        public String Descripcion { get { return _descripcion; } }
    }
    public class AlMolde : Masa
    {
        public AlMolde() {
            _descripcion = "Masa al molde";
        }
    }

    public class ALaPiedra : Masa
    {
        public ALaPiedra()
        {
            _descripcion = "Masa a la piedra";
        }
    }

    public class Integral : Masa
    {
        public Integral()
        {
            _descripcion = "Masa integral";
        }
    }
}


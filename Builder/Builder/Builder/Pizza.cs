using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Pizza
    {
        Masa _masa;
        Salsa _salsa;
        Agregado _agregado;
        String _tipo;

        public override String ToString()
        {
            return $"{_tipo}, Masa:{_masa.Descripcion},Salsa:{_salsa.Descripcion},Agregado:{_agregado.Descripcion}";
        }

        public Pizza(Masa masa,Salsa salsa,Agregado agregado,String tipo)
        {
            _masa = masa;
            _salsa = salsa;
            _agregado = agregado;
            _tipo = tipo;
        }
    }
}

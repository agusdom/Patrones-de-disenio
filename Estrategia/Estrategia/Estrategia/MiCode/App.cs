using Estrategia.Estrategia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrategia
{
    internal class App
    {
        static void Main(string[] args)
        {
            Contexto contexto = new Contexto(new AntivirusAvanzado());
            contexto.Ejecutar();
            Console.ReadLine();
        }
    }
}

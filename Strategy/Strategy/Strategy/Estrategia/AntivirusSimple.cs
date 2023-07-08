using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Strategy.Estrategia
{
    public class AntivirusSimple : AnalisisSimple
    {
        protected override void Detener()
        {
            Console.WriteLine("Antivirus Simple - Análisis Simple Finalizado");
        }

        protected override void Iniciar()
        {
            Console.WriteLine("Antivirus Simple - Análisis Simple Iniciado");
        }

        protected override void SaltaZip()
        {
            try
            {
                Console.WriteLine("Analizando.....");
                Thread.Sleep(2500);
                Console.WriteLine("No pudo analizar archivos con extension '.zip'"); 
            }catch (ThreadInterruptedException e)
            {
                Console.WriteLine($"{e.Message}");
            }
        }
    }
}

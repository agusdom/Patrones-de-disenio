using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Estrategia.Estrategia
{
    public class AntivirusAvanzado : AnalisisAvanzado
    {
        protected override void AnalizarKeyLoggers()
        {
            try
            {
                Console.WriteLine("Analizando en busca de Key Loggers.....");
                Thread.Sleep(1000);
            }
            catch (ThreadInterruptedException e)
            {
                Console.WriteLine($"{e.Message}");
            }
        }

        protected override void AnalizarMemoria()
        {
            try
            {
                Console.WriteLine("Analizando Memoria RAM.....");
                Thread.Sleep(1000);
            }
            catch (ThreadInterruptedException e)
            {
                Console.WriteLine($"{e.Message}");
            }
        }

        protected override void AnalizarRootKits()
        {
            try
            {
                Console.WriteLine("Analizando en busca de Root Kits.....");
                Thread.Sleep(1500);
            }
            catch (ThreadInterruptedException e)
            {
                Console.WriteLine($"{e.Message}");
            }
        }

        protected override void DescomprimirZip()
        {
            try
            {
                Console.WriteLine("Analizando los archivos ZIP.....");
                Thread.Sleep(2000);
            }
            catch (ThreadInterruptedException e)
            {
                Console.WriteLine($"{e.Message}");
            }
        }

        protected override void Detener()
        {
            Console.WriteLine("Antivirus Avanzado - Análisis Avanzado Finalizado");
        }

        protected override void Iniciar()
        {
            Console.WriteLine("Antivirus Avanzado - Análisis Avanzado Iniciado");
        }

    }
}

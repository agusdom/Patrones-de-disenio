using Prototype.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class MyConfiguracion : IConfiguration
    {
        public String Setting1 { get; set; }
        public int Setting2 { get; set; }
        public bool Setting3 { get; set; }

        public MyConfiguracion(String setting1,int setting2,bool setting3) { 
         Setting1 = setting1;
         Setting2 = setting2;
         Setting3 = setting3;
        }

        public IConfiguration Clone()
        {
            return new MyConfiguracion(Setting1,Setting2,Setting3);
        }

        public void toString()
        {
            Console.WriteLine($"Original: Setting1 = {Setting1},Setting2 = {Setting2},Setting3 = {Setting3}");
        }
    }
}

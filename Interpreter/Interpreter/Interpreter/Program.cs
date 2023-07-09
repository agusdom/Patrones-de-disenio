using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.CompilerServices;

namespace Interpreter
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] tree;
            var context = new Context();
            var expressions = new List<IExpression>();
            Console.WriteLine("ingrese la operacion en letras: ");
            string val = Console.ReadLine();
            tree = val.Split(' ');
            IExpression exp;
            foreach (var t in tree)
            {
                if (Operators.ConditionalCompareObjectGreaterEqual(context.getInteger(t), 0, false))
                {
                    exp = new NumericExpression(t);
                }
                else
                {
                    exp = new OperatorExpression(t);
                }

                exp.Interpret(context);
            }

            Console.WriteLine("El resultado para '" + val + "' es " + context.getResult());
            Console.ReadKey();
        }
    }
}

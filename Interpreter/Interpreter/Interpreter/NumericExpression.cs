using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    public class NumericExpression : IExpression
    {
       private String _value;

        public NumericExpression(String token)
        {
            _value = token;
        }

        public void Interpret(Context context)
        {
            context.setOperator(context.getInteger(_value));
            context.Calculate();
        }
    }
}

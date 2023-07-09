using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    public class OperatorExpression : IExpression
    {
        private String _operation;

        public OperatorExpression(String token)
        {
            _operation = token;
        }

        public void Interpret(Context context)
        {
            context.setOperation(_operation);
        }
    }
}

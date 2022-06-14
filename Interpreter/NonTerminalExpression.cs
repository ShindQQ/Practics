using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    internal class NonTerminalExpression : AbstractExpresion
    {
        AbstractExpresion nonterminalExpression;
        AbstractExpresion terminalExpression;

        public override void Interpret(Context context)
        {
            if (context.Position < context.Source.Length)
            {
                terminalExpression = new TerminalExpression();
                terminalExpression.Interpret(context);
                context.Position++;

                if (context.Result)
                {
                    nonterminalExpression = new NonTerminalExpression();
                    nonterminalExpression.Interpret(context);
                }
            }
        }
    }
}

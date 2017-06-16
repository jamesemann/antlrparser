using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Antlr4.Runtime;
using Antlr4.Runtime.Misc;

namespace Antlrtest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var variables = new List<SerializableKeyValuePair>();
            variables.Add(new SerializableKeyValuePair {Key = "bob1", Value = "1"}); // {  "bob1", "1"};
            variables.Add(new SerializableKeyValuePair {Key = "bob1", Value = "2"});
            variables.Add(new SerializableKeyValuePair {Key = "age", Value = "18"});

            var inputStream = new StringReader("$age >= 18 AND $age <= 21");
            var input = new AntlrInputStream(inputStream.ReadToEnd());
            var lexer = new HelloLexer(input);
            var tokens = new CommonTokenStream(lexer);
            var parser = new HelloParser(tokens);

            var r = parser.prog();

            var visitor = new Visitor(variables);
            Console.WriteLine(visitor.Visit(r));
        }
    }

    [Serializable]
    public class SerializableKeyValuePair
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }

    public class Visitor : HelloBaseVisitor<object>
    {
        private readonly List<SerializableKeyValuePair> _variables;
        public List<string> dependentVariables = new ArrayList<string>();

        public Visitor(List<SerializableKeyValuePair> variables)
        {
            _variables = variables;
        }

        public override object VisitOtherEquality(HelloParser.OtherEqualityContext context)
        {
            var lhs = Visit(context.expr(0));
            if (lhs == null)
                return false;

            var rhs = Visit(context.expr(1));
            if (rhs == null)
                return false;

            var left = decimal.Parse(lhs.ToString());
            var right = decimal.Parse(rhs.ToString());

            if (context.op.Type == HelloParser.GT)
                return left > right;
            if (context.op.Type == HelloParser.GTE)
                return left >= right;
            if (context.op.Type == HelloParser.LT)
                return left < right;
            if (context.op.Type == HelloParser.LTE)
                return left <= right;

            throw new Exception("can only evaluate terms that can be reduced to decimals");
        }

        public override object VisitOr(HelloParser.OrContext context)
        {
            var left = Visit(context.expr(0));
            var right = Visit(context.expr(1));

            bool truthyLeft;
            bool truthyRight;

            if (left == null || left is bool && (bool) left == false)
                truthyLeft = false;
            else
                truthyLeft = true;

            if (right == null || right is bool && (bool) right == false)
                truthyRight = false;
            else
                truthyRight = true;

            return truthyLeft || truthyRight;
        }

        public override object VisitAnd(HelloParser.AndContext context)
        {
            var left = Visit(context.expr(0));
            var right = Visit(context.expr(1));

            bool truthyLeft;
            bool truthyRight;

            if (left == null || left is bool && (bool) left == false)
                truthyLeft = false;
            else
                truthyLeft = true;

            if (right == null || right is bool && (bool) right == false)
                truthyRight = false;
            else
                truthyRight = true;

            return truthyLeft && truthyRight;
        }

        public override object VisitNull(HelloParser.NullContext context)
        {
            return null;
        }

        public override object VisitStringLiteral(HelloParser.StringLiteralContext context)
        {
            return context.STR().GetText().Trim('"');
        }

        public override object VisitVariable(HelloParser.VariableContext context)
        {
            var key = context.VAR().GetText().TrimStart('$');

            if (!dependentVariables.Contains(key))
                dependentVariables.Add(key);


            return _variables.Any(x => x.Key == key) ? _variables.FirstOrDefault(x => x.Key == key).Value : null;
        }

        public override object VisitInt(HelloParser.IntContext context)
        {
            return int.Parse(context.INT().GetText());
        }

        public override object VisitNotEquals(HelloParser.NotEqualsContext context)
        {
            var left = Visit(context.expr(0));
            var right = Visit(context.expr(1));

            if (left == null && right == null)
                return true;
            if (left == null || right == null)
                return false;

            return !left.ToString().Equals(right.ToString());
        }

        public override object VisitEquals(HelloParser.EqualsContext context)
        {
            var left = Visit(context.expr(0));
            var right = Visit(context.expr(1));

            if (left == null && right == null)
                return true;
            if (left == null || right == null)
                return false;

            return left.ToString().Equals(right.ToString());
        }

        public override object VisitAddSub(HelloParser.AddSubContext context)
        {
            var left = (int) Visit(context.expr(0));
            var right = (int) Visit(context.expr(1));
            if (context.op.Type == HelloParser.ADD)
                return left + right;
            return left - right;
        }

        public override object VisitMulDiv(HelloParser.MulDivContext context)
        {
            var left = (int) Visit(context.expr(0));
            var right = (int) Visit(context.expr(1));
            if (context.op.Type == HelloParser.MUL)
                return left * right;
            return left / right;
        }

        public override object VisitParens(HelloParser.ParensContext context)
        {
            return Visit(context.expr());
        }
    }
}
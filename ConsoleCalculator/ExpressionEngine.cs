using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleCalculator
{
    public class ExpressionEngine
    {
        private readonly Tokenizer _tokenizer;

        public ExpressionEngine()
        {
            _tokenizer = new Tokenizer();
        }

        public double Calculate(string input)
        {
            try
            {
                var tokens = _tokenizer.Tokenize(input).ToArray();
                double result = 0;
                var temp = new Stack<double>();

                foreach (var t in tokens)
                {
                    if (double.TryParse(t, out var tempNumber))
                    {
                        temp.Push(tempNumber);
                    }
                    else if (t.First().IsOperator())
                    {
                        var a = temp.Pop();
                        var b = temp.Pop();

                        result = t.FirstOrDefault() switch
                        {
                            '+' => b + a,
                            '-' => b - a,
                            '*' => b * a,
                            '/' => b / a,
                            _ => result
                        };
                        temp.Push(result);
                    }
                }

                return temp.Peek();
            }
            catch (Exception)
            {
                throw new SystemException();
            }
        }
    }
}
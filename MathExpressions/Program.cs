using System;

namespace MathExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            ITokenizer tokenizer = new Tokenizer();
            tokenizer.NextToken();
        }
    }
}
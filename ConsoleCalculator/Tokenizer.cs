using System.Collections.Generic;

namespace ConsoleCalculator
{
    class Tokenizer
    {
        internal List<string> Tokenize(string input)
        {
            var result = new List<string>();
            var operationStack = new Stack<char>();

            for (var i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    var currentNumber = "";
                    while (!input[i].IsOperator())
                    {
                        currentNumber += input[i];
                        i++;

                        if (i == input.Length) break;
                    }

                    result.Add(currentNumber); 
                    i--;
                }

                if (!input[i].IsOperator()) continue;
                
                switch (input[i])
                {
                    case '(':
                        operationStack.Push(input[i]);
                        break;
                    case ')':
                    {
                        var symbol = operationStack.Pop();

                        while (symbol != '(')
                        {
                            result.Add(symbol.ToString());
                            symbol = operationStack.Pop();
                        }
                        break;
                    }
                    default:
                    {
                        if (operationStack.Count > 0)
                        {
                            if (input[i].GetOperationPriority() <= operationStack.Peek().GetOperationPriority())
                            {
                                result.Add(operationStack.Pop().ToString());
                            }
                        }
                        
                        operationStack.Push(input[i]);
                        break;
                    }
                }
            }

            while (operationStack.Count > 0)
            {
                result.Add(operationStack.Pop().ToString());   
            }

            return result;
        }
    }
}
using System;

namespace MathExpressions
{
    public class Tokenizer : ITokenizer
    {
        public string InputString { get; set; } = "12+5-2/3*10";
        public Token CurrentToken { get; private set; }
        private double? _number;
        private string _currentNumber = "";
        
        public void NextToken()
        {
            for (var i = 0; i < InputString.Length; i++)
            {
                var isLast = i == InputString.Length - 1;
                
                if (char.IsDigit(InputString[i]))
                {
                    _currentNumber += InputString[i];
                    if (!isLast)
                    {
                        continue;    
                    }
                }

                if (!string.IsNullOrWhiteSpace(_currentNumber))
                {
                    if (_number == null)
                    {
                        _number = int.Parse(_currentNumber);    
                    }
                    else
                    {
                         _number = DoOperation(_number, CurrentToken, int.Parse(_currentNumber));
                    }
                    
                    _currentNumber = "";
                }

                if (!isLast)
                {
                    Tokenize(InputString[i]);
                }
            }
            
            Console.WriteLine(_number);
        }

        private void Tokenize(char input)
        {
            switch (input)
            {
                case '+':
                    CurrentToken = Token.Add;
                    break;
                case '-':
                    CurrentToken = Token.Subtract;
                    break;
                case '*':
                    CurrentToken = Token.Multiply;
                    break;
                case '/':
                    CurrentToken = Token.Divide;
                    break;
                case '(':
                    CurrentToken = Token.OpenBracket;
                    break;
                case ')':
                    CurrentToken = Token.CloseBracket;
                    break;
                default:
                    throw new Exception();
            }
        }

        private double DoOperation(double? firstNumber, Token token, double? secondNumber)
        {
            if (token == Token.Divide && secondNumber == 0)
                throw new SystemException("Невозможно делить на 0");

            if (firstNumber == null || secondNumber == null)
                throw new SystemException();
            
            switch (token)
            {
                case Token.Add:
                    return (double)firstNumber + (double)secondNumber;
                case Token.Subtract:
                    return (double)firstNumber - (double)secondNumber;
                case Token.Multiply:
                    return (double)firstNumber * (double)secondNumber;
                case Token.Divide:
                    // ReSharper disable once PossibleLossOfFraction
                    return (double)firstNumber / (double)secondNumber;
                default: throw new SystemException();
            }
        }
    }
}
using System;

namespace ConsoleCalculator.Exceptions
{
    public class UnrecognizedSymbolException : Exception
    {
        public UnrecognizedSymbolException(string message) : base(message)
        {
        }
    }
}
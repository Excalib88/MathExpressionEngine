using System;
using ConsoleCalculator;

namespace TestCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введите выражение: ");
                Console.WriteLine(ExpressionEngine.Calculate(Console.ReadLine()));
            }       
        }
    }
}
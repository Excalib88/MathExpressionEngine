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
                try
                {
                    Console.Write("Введите выражение: ");
                    Console.WriteLine(ExpressionEngine.Calculate(Console.ReadLine()));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }
    }
}
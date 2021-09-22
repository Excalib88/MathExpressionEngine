using System;
using System.Collections.Generic;

namespace ConsoleCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введите выражение: ");
                Console.WriteLine(new ExpressionEngine().Calculate(Console.ReadLine()));
            }
        }
    }
}

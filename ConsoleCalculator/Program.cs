using System;
using System.Collections.Generic;

namespace ConsoleCalculator
{
    // class RPN
    // {
    //     public static double Calculate(string input)
    //     {
    //         var output = GetExpression(input); 
    //         var result = Counting(output);
    //         return result;
    //     }
    //     private static string GetExpression(string input)
    //     {
    //         var output = string.Empty;
    //         var operationStack = new Stack<char>();
    //
    //         for (var i = 0; i < input.Length; i++)
    //         {
    //             if (char.IsDigit(input[i]))
    //             {
    //                 while (!IsOperator(input[i]))
    //                 {
    //                     output += input[i];
    //                     i++;
    //
    //                     if (i == input.Length) break;
    //                 }
    //
    //                 output += " "; 
    //                 i--;
    //             }
    //
    //             if (!IsOperator(input[i])) continue;
    //             
    //             switch (input[i])
    //             {
    //                 case '(':
    //                     operationStack.Push(input[i]);
    //                     break;
    //                 case ')':
    //                 {
    //                     var s = operationStack.Pop();
    //
    //                     while (s != '(')
    //                     {
    //                         output += s.ToString() + ' ';
    //                         s = operationStack.Pop();
    //                     }
    //                     break;
    //                 }
    //                 default:
    //                 {
    //                     if (operationStack.Count > 0)
    //                         if (GetPriority(input[i]) <= GetPriority(operationStack.Peek()))
    //                             output += operationStack.Pop() + " ";
    //                     operationStack.Push(input[i]);
    //                     break;
    //                 }
    //             }
    //         }
    //
    //         while (operationStack.Count > 0)
    //             output += operationStack.Pop() + " ";
    //
    //         return output;
    //     }
    //     private static double Counting(string input)
    //     {
    //         double result = 0;
    //         var temp = new Stack<double>();
    //
    //         for (var i = 0; i < input.Length; i++)
    //         {
    //             if (char.IsDigit(input[i]))
    //             {
    //                 var tempNumber = string.Empty;
    //
    //                 while (!IsDelimiter(input[i]) && !IsOperator(input[i]))
    //                 {
    //                     tempNumber += input[i];
    //                     i++;
    //                     if (i == input.Length) break;
    //                 }
    //                 temp.Push(double.Parse(tempNumber));
    //                 i--;
    //             }
    //             else if (IsOperator(input[i]))
    //             {
    //                 var a = temp.Pop();
    //                 var b = temp.Pop();
    //
    //                 result = input[i] switch
    //                 {
    //                     '+' => b + a,
    //                     '-' => b - a,
    //                     '*' => b * a,
    //                     '/' => b / a,
    //                     _ => result
    //                 };
    //                 temp.Push(result);
    //             }
    //         }
    //
    //         return temp.Peek();
    //     }
    //     private static bool IsDelimiter(char c)
    //     {
    //         return " =".IndexOf(c) != -1;
    //     }
    // }
    class Program
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

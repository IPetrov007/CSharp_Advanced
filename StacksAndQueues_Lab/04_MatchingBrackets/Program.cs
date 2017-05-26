using System;
using System.Collections.Generic;

namespace _04_MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var indexOfBrackets = new Stack<int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    indexOfBrackets.Push(i);
                }
                else if (input[i] == ')')
                {
                    Console.WriteLine(input.Substring(indexOfBrackets.Peek(), (i - indexOfBrackets.Pop() + 1)));
                }
                
            }
        }
    }
}

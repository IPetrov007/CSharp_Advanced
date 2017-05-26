using System;
using System.Collections.Generic;

namespace _01_ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToCharArray();
            Stack<char> stack = new Stack<char>(input);
            
            Console.WriteLine(string.Join("", stack));
        }
    }
}

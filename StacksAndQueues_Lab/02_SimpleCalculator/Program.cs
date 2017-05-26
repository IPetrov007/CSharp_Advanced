using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>(Console.ReadLine().Split().Reverse());
            while (true)
            {
                var first = int.Parse(stack.Pop());
                var sign = stack.Pop();
                var second = int.Parse(stack.Pop());

                if (sign == "+")
                {
                    stack.Push((first + second).ToString());
                }
                else if (sign == "-")
                {
                    stack.Push((first - second).ToString());
                }
                if (stack.Count == 1)
                {
                    break;
                }
            }

            Console.WriteLine(stack.Peek());
        }
    }
}

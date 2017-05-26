using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_DecimalToBinaryConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            Stack<int> result = new Stack<int>();
            if (num == 0)
            {
                Console.WriteLine(0);
            }else
            {
                while (num > 0)
                {
                    result.Push(num % 2);
                    num /= 2;
                }
            }
            Console.WriteLine(string.Join("", result));
        }
    }
}

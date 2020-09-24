using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {

            var nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int capacity = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>(nums);
            int rackCounter = 1;
            int sum = 0;

            while (stack.Count > 0)
            {
                var curent = stack.Peek();
                

                if (sum + curent > capacity)
                {
                    rackCounter++;
                    sum = 0;

                }
                else
                {
                   sum += stack.Pop();
                }
            }

            Console.WriteLine(rackCounter);  
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _07._Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPomps = int.Parse(Console.ReadLine());

            Queue<string> circle = new Queue<string>();

            for (int i = 0; i < numOfPomps; i++)
            {
                string input = Console.ReadLine();

                input += $" {i}";
                circle.Enqueue(input);
            }

            int totalFuel = 0;

            for (int i = 0; i < numOfPomps; i++)
            {
                string curentInfo = circle.Dequeue();

                var info = curentInfo.Split().Select(int.Parse).ToArray();

                var fuel = info[0];
                var distance = info[1];
                totalFuel += fuel;

                if (totalFuel >= distance)
                {
                    totalFuel -= distance;

                }
                else
                {
                    totalFuel = 0;

                    i = -1;
                }

                circle.Enqueue(curentInfo);
            }

            var firstElemen = circle.Dequeue().Split().ToArray();

            Console.WriteLine(firstElemen[2]);

        }
    }
}

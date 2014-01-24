using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Joro_the_rabbit
{
    class JoroTheRabbit
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            int[] route = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                route[i] = int.Parse(input[i]);
            }

            int bestPath = 0;

            for (int startIndex = 0; startIndex < route.Length; startIndex++)
            {
                for (int step = 1; step < route.Length; step++)
                {
                    int index = startIndex;
                    int currentPath = 1;
                    int next = ((index + step) % route.Length);

                    while (route[index] < route[next])                     //next != startIndex && 
                    {
                        currentPath++;
                        index = next;
                        next = (index + step) % route.Length;
                    }

                    if (bestPath < currentPath)
                    {
                        bestPath = currentPath;
                    }
                }
            }

            Console.WriteLine(bestPath);


        }
    }
}

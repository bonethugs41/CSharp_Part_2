using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Greedy_dwarf
{
    class Program
    {
        static long ProccessPattern(int[] valley)
        {
            string[] rawNUmbers = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            int[] pattern = new int[rawNUmbers.Length];

            for (int i = 0; i < pattern.Length; i++)
            {
                pattern[i] = int.Parse(rawNUmbers[i]);
            }

            long coinsSum = 0;
            coinsSum += valley[0];

            bool[] vissited = new bool[valley.Length];
            vissited[0] = true;

            int currentPosition = 0;

            while (true)
            {
                for (int i = 0; i < pattern.Length; i++)
                {
                    int nextMove = currentPosition + pattern[i];

                    if (nextMove >= 0 && nextMove < valley.Length && !vissited[nextMove])
                    {
                        coinsSum += valley[nextMove];
                        vissited[nextMove] = true;
                        currentPosition = nextMove;
                    }
                    else
                    {
                        return coinsSum;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            string[] rawNUmbers = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            int[] valleyNumbers = new int[rawNUmbers.Length];

            for (int i = 0; i < rawNUmbers.Length; i++)
            {
                valleyNumbers[i] = int.Parse(rawNUmbers[i]);
            }

            int numberOfPatterns = int.Parse(Console.ReadLine());

            long bestSum = long.MinValue;

            for (int i = 0; i < numberOfPatterns; i++)
            {
                long sum = ProccessPattern(valleyNumbers);

                if (sum > bestSum)
                {
                    bestSum = sum;
                }
            }
            Console.WriteLine(bestSum);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Multiverse_communication
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] inputArray = new string[input.Length / 3];
            int move = 0;
            for (int i = 0; i < input.Length; i++)
            {
                inputArray[i] = input.Substring(move, 3);
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Genome_decoder
{
    class GenomeDecoder
    {

        static string GetFromString(string digit)
        {
            string result = "NO";
            switch (digit)
            {
                case "A": ; break;
                case "G": ; break;
                case "T": ; break;
                case "C": ; break;
                default:
                    break;
            }
            return result;
        }


        static void Main()
        {
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');
            int n = int.Parse(numbers[0]);
            int m = int.Parse(numbers[1]);
            string inputCode = Console.ReadLine();

        }
    }
}

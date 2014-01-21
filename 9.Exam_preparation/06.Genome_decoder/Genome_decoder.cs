using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//Don't work correctly
namespace _06.Genome_decoder
{
    class GenomeDecoder
    {


        static void Main()
        {
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');
            int n = int.Parse(numbers[0]);
            int m = int.Parse(numbers[1]);
            string inputCode = Console.ReadLine();

            StringBuilder decodedGenome = DecodeGenome(inputCode);
            //  Console.WriteLine(decodedGenome);

            PrintOutput(decodedGenome, m, n);
        }

        private static void PrintOutput(StringBuilder decodedGenome, int spaces, int lines)
        {
            string printing = decodedGenome.ToString();
            int counter = 1;
            int counterLines = 1;
            Console.Write(1 + " ");

            for (int i = 0; i < printing.Length; i++)
            {
                Console.Write(printing[i]);
                if (i % spaces == 0)
                {
                    Console.Write(" ");
                    counter++;
                }
                if (i == printing.Length - 1)
                {
                    Console.WriteLine();
                    break;
                }
                if (i + 1 == lines * counterLines)
                {
                    Console.WriteLine();
                    Console.Write(counter + 1 + " ");
                    counterLines++;
                }


            }
        }

        private static StringBuilder DecodeGenome(string inputCode)
        {
            StringBuilder decodedGenom = new StringBuilder();
            StringBuilder repeatTimesString = new StringBuilder();

            foreach (char item in inputCode)
            {
                if (item == 'A' || item == 'G' || item == 'C' || item == 'T')
                {
                    int repeatTimes = 1;
                    if (repeatTimesString.Length != 0)
                    {
                        repeatTimes = int.Parse(repeatTimesString.ToString());
                        repeatTimesString.Clear();
                    }
                    string genomeSubseq = new string(item, repeatTimes);
                    decodedGenom.Append(genomeSubseq);
                }
                else
                {
                    repeatTimesString.Append(item);
                }
            }

            return decodedGenom;
        }
    }
}

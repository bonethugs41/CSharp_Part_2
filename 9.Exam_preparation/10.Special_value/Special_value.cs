using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Special_value
{
    class SpecialValue
    {

        static int[][] ReadData(int[][] field)
        {
            for (int i = 0; i < field.GetLength(0); i++)
            {
                string[] currentLine = Console.ReadLine().Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries);

                field[i] = new int[currentLine.Length];

                for (int j = 0; j < currentLine.Length; j++)
                {
                    field[i][j] = int.Parse(currentLine[j]);

                }
            }
            return field;
        }

        static long FindCurrentSpecialValue(int[][] field, int column, bool[][] used)
        {
            long result = 0;
            int currentRow = 0;

            while (true)
            {
                if (used[currentRow][column])
                {
                    
                }
                currentRow++;
                result++;
            }

            return result;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[][] field = new int[n][];

            ReadData(field);

            bool[][] used = new bool[n][];

        }
    }
}

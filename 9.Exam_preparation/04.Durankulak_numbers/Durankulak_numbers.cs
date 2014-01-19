using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Durankulak_numbers
{
    class Durankulak_numbers
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int index = 0;
            long sum = 0L;
            int digits = -1;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= 97)
                {
                    digits++;
                    i++;
                }
                else
                {
                    digits++;
                }
            }
            string[] letters = new string[168];
            int move = 0;

            for (int i = 0; i < 26; i++)
            {
                letters[i] = ((char)('A' + move)).ToString();
                move++;
            }
            int position = 26;

            for (char i = 'a'; i <= 'z'; i++)
            {
                for (char j = 'A'; j <= 'Z'; j++)
                {
                    if (position == 168)
                    {
                        break;
                    }
                    letters[position] = i.ToString() + j.ToString();
                    position++;
                }
            }
            string search;

            for (int i = 0; i < input.Length; i++)
            {
                search = input[i].ToString();
                if (input[i] >= 97)
                {
                    search = input[i].ToString() + input[i + 1];
                    i++;
                }

                for (int j = 0; j < letters.Length; j++)
                {
                    if (search == letters[j])
                    {
                        index = j;
                        sum = sum + index * (long)(Math.Pow(168, digits));
                        break;
                    }
                }
                digits--;
            }
            Console.WriteLine(sum);
        }
    }
}

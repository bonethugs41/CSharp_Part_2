using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Moving_letters
{
    class MovingLetters
    {

        static StringBuilder ExtractLetters(string[] words)
        {
            int maxLength = 0;
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < words.Length; i++)
            {
                string currentWord = words[i];
                if (maxLength < words[i].Length)
                {
                    maxLength = currentWord.Length;
                }
            }

            for (int i = 0; i < maxLength; i++)
            {
                for (int j = 0; j < words.Length; j++)
                {
                    string currentWord = words[j];

                    if (i < currentWord.Length)
                    {
                        int lastLetterIndex = currentWord.Length - i - 1;
                        result.Append(currentWord[lastLetterIndex]);
                    }
                }
            }
            return result;
        }

        static string MoveLetters(StringBuilder unorderedLetters)
        {
            for (int i = 0; i < unorderedLetters.Length; i++)
            {
                char current = unorderedLetters[i];
                int transition = char.ToLower(current) - 'a' + 1;                           //Gives the alphabetical number

                unorderedLetters.Remove(i, 1);

                int nextPosition = (i + transition) % (unorderedLetters.Length + 1);         //Removes the current letter from its position
                unorderedLetters.Insert(nextPosition, current);                              //Insert the letter in to the new position

            }

            return unorderedLetters.ToString();
        }

        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            StringBuilder unorderedLetters = ExtractLetters(words);

            string finalResult = MoveLetters(unorderedLetters);

            Console.WriteLine(finalResult);
        }
    }
}

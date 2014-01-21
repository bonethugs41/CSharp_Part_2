using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Magic_words
{
    class MagicWords
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var words = new List<string>();

            for (int i = 0; i < n; i++)
            {
                words.Add(Console.ReadLine());
            }

            //Reorder

            for (int i = 0; i < n; i++)
            {
                var word = words[i];
                var newIndex = word.Length % (n + 1);

                //words[i] = null;
                //words.Insert(newIndex, word);
                //words.Remove(null);

                words.Insert(newIndex, word);
                if (newIndex < i)
                {
                    words.RemoveAt(i + 1);
                }
                else if (newIndex >= i)
                {
                    words.RemoveAt(i);
                }
            }

            //print

            var maxLength = 0;
            foreach (var word in words)
            {
                maxLength = Math.Max(maxLength, word.Length);                               //Gives the longest word
            }

            //var maxLength = words.Max(x => x.Length);


            var result = new StringBuilder();
            for (int i = 0; i < maxLength; i++)
            {
                foreach (var word in words)
                {
                    if (word.Length > i)
                    {
                        result.Append(word[i]);
                    }
                }
            }

            Console.WriteLine(result.ToString());
        }
    }
}

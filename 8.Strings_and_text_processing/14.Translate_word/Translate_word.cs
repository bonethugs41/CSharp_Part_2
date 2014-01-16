//A dictionary is stored as a sequence of text lines containing words
//and their explanations. Write a program that enters a word and translates it by using the dictionary.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Dictionary
{
    class Dictionary
    {
        static string[] Split(string dictionary)
        {
            string[] parts = dictionary.Split('\n', '-');
            for (int i = 0; i < parts.Length; i++)
            {
                parts[i] = parts[i].Trim();
            }
            return parts;
        }
        static void User(string[] parts)
        {
            Console.WriteLine("Enter word:");
            string word = Console.ReadLine();
            bool answer = false;
            int index = 0;
            for (int i = 0; i < parts.Length; i++)
            {
                if (word.ToLower() == parts[i].ToLower())
                {
                    answer = true;
                    index = i;
                }
            }
            if (answer == true)
            {
                Console.WriteLine("This is {0}!", parts[index + 1]);
            }
            else
            {
                Console.WriteLine("The Word is not in dictionary!");
            }
        }
        static void Main(string[] args)
        {
            StringBuilder builder = new StringBuilder();
            string dictionary;
            Console.WriteLine("Enter words and their explanations separated by \"-\"");
            while (true)
            {
                dictionary = Console.ReadLine();
                if (dictionary != "")
                {
                    builder.Append(dictionary + "\n");
                }
                else
                {
                    break;
                }
            }
            dictionary = builder.ToString();
            string[] parts = Split(dictionary);
            User(parts);
        }
    }
}
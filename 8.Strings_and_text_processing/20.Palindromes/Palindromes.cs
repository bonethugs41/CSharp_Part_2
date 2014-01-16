//Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".

using System;

class Palindromes
{
    static void Symetric(string[] parts)
    {
        bool symetric = true;
        string word;
        for (int i = 0; i < parts.Length; i++)
        {
            word = parts[i].Trim().ToLower();
            for (int j = 0; j < (word.Length) / 2; j++)
            {
                if (word[j] != word[word.Length - 1 - j])
                {
                    symetric = false;
                }
                else
                {
                    symetric = true;
                }
            }
            if (symetric == true)
            {
                Console.WriteLine(parts[i]);
            }
        }
    }
    static void Main()
    {
        Console.WriteLine("Enter sentence:");
        string sentence = Console.ReadLine();
        Console.WriteLine();
        string[] parts = sentence.Split(' ', ',', '!', '?', '.', '(', ')');
        Console.WriteLine("Palindromes:");
        Symetric(parts);
    }
}
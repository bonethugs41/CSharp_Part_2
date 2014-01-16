//Write a program that reads a string from the console and lists all different words
//in the string along with information how many times each word is found.

using System;

class WordsInAString
{
    static void Main()
    {
        Console.WriteLine("Enter string:");
        string text = Console.ReadLine();
        string[] parts = text.Split(' ', ',', '!', '?', '.', '(', ')');
        int count = 1;
        for (int i = 0; i < parts.Length; i++)
        {
            for (int j = i + 1; j < parts.Length; j++)
            {
                if (parts[i] == parts[j])
                {
                    count++;
                    parts[j] = null;
                }
            }
            if (parts[i] == null)
            {
                break;
            }
            Console.WriteLine("{0} -> {1}", parts[i].Trim(), count);
            count = 1;
        }
    }
}
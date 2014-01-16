//Write a program that reads a string from the console and prints all
//different letters in the string along with information how many times each letter is found.
using System;

class LettersInAString
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter string:");
        string text = Console.ReadLine();
        int[] letters = new int[150];
        for (int i = 0; i < letters.Length; i++)
        {
            for (int j = 0; j < text.Length; j++)
            {
                if (text[j] == ' ')
                {
                    continue;
                }
                if (i == (int)text[j])
                {
                    letters[i]++;
                }
            }
        }
        for (int i = 0; i < letters.Length; i++)
        {
            if (letters[i] == 0)
            {
                continue;
            }
            else
            {
                Console.WriteLine("{0} -> {1} times", (char)i, letters[i]);
            }
        }
    }
}
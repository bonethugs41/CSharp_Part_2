//Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).


using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.Title = "Search for a given substring";
        Console.Write("Enter text: ");
        string text = Console.ReadLine();
        Console.Write("Enter word: ");
        string word = Console.ReadLine();
        Console.WriteLine("The result is: {0}", SearchWord(text, word)); 
    }

    private static int SearchWord(string text, string word)
    {
        text = text.ToLower();
        int counter = 0;
        int index = text.IndexOf(word, 0);
        while (index != -1 && index < text.Length)
        {
            counter++;
            index = text.IndexOf(word, index + 1);
        }
        return counter;
    }
}
//We are given a string containing a list of forbidden words and a text containing some of these words.
//Write a program that replaces the forbidden words with asterisks. 

using System;

class Censored
{
    static void Main()
    {
        Console.Title = "Censored words";
        string text = @"Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
        Console.Write("Enter words to be censored: ");                      //PHP, CLR, Microsoft
        string wordList = Console.ReadLine();
        string[] list = wordList.Split(',');
        Console.WriteLine();
        Console.WriteLine(Censor(text, list));

    }

    private static string Censor(string text, string[] list)
    {
        string word;
        string textLower = text.ToLower();
        for (int i = 0; i < list.Length; i++)
        {
            word = list[i].Trim();
            text = text.Replace(word, "*".PadLeft(word.Length, '*'));
        }
        return text;
    }
}
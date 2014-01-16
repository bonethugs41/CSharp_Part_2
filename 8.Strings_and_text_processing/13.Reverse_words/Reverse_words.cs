//Write a program that reverses the words in given sentence.
//        Example: "C# is not C++, not PHP and not Delphi!"  "Delphi not and PHP, not C++ not is C#!".

using System;
using System.Text;

class ReverseWordsInSentence
{
    static string Reverse(string[] parts)
    {
        StringBuilder builder = new StringBuilder();
        for (int i = parts.Length - 1; i >= 0; i--)
        {
            builder.Append(parts[i] + " ");
        }
        return builder.ToString().Trim();
    }
    static void Main()
    {
        Console.WriteLine("Enter sentence:");
        string sentence = Console.ReadLine();
        string[] parts = sentence.Split(' ', ',', '!', '?', '.');
        string newSentence = Reverse(parts);
        Console.WriteLine("Reversed Sentence:");
        Console.WriteLine(newSentence);
    }
}
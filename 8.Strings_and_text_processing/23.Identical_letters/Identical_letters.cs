//Write a program that reads a string from the console and replaces all series
//of consecutive identical letters with a single one.
//Example: "aaaaabbbbbcdddeeeedssaa"  "abcdedsa".

using System;
using System.Text;

class IdenticalLetters
{
    static void Main()
    {
        StringBuilder builder = new StringBuilder();
        Console.WriteLine("Enter string:");
        string text = Console.ReadLine();
        for (int i = 0; i < text.Length - 1; i++)
        {
            if (text[i + 1] == text[i])
            {
                if (i + 1 == text.Length - 1)
                {
                    builder.Append(text[i]);
                }
                continue;
            }
            else
            {
                builder.Append(text[i]);
                if (i + 1 == text.Length - 1)
                {
                    builder.Append(text[i + 1]);
                }
            }
        }
        Console.WriteLine(builder.ToString());
    }
}
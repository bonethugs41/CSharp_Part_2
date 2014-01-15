//You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to uppercase. 
//The tags cannot be nested. 

using System;
using System.Text;

class TextInTags
{
    static void Uppercase(string text)
    {
        int startIndex = 0;
        int endIndex = 0;

        for (int i = 0; i < text.Length - 8; i++)
        {
            if (text.Substring(i, 8) == "<upcase>")
            {
                startIndex = i + 8;
                i = startIndex;
            }
            if (text.Substring(i, 9) == "</upcase>")
            {
                endIndex = i;
                int length = endIndex - startIndex;
                string upperStr = text.Substring(startIndex, length).ToUpper();
                text = text.Remove(startIndex, length);
                text = text.Insert(startIndex, upperStr);
                text = text.Remove(startIndex - 8, 8);
                text = text.Remove(endIndex - 8, 9);
            }
        }
        Console.WriteLine(text);
    }
    static void Main()
    {
        Console.WriteLine("Enter Text:");
        string text = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Changed Text:");
        Uppercase(text);
    }
}
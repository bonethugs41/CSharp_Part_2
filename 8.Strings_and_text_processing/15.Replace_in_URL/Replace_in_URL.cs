//Write a program that replaces in a HTML document given as string all the tags
//<a href="…">…</a> with corresponding tags [URL=…]…/URL].

using System;

class ReplaceAWithURL
{
    static void Replace(string text)
    {
        for (int i = 0; i < text.Length - 8; i++)
        {
            if (text.Substring(i, 8) == "<a href=")
            {
                text = text.Remove(i, 8);
                text = text.Insert(i, "[URL=");
                for (int j = i + 8; j < text.Length - 8; j++)
                {
                    if (text.Substring(j, 1) == ">")
                    {
                        text = text.Remove(j, 1);
                        text = text.Insert(j, "]");
                    }
                    if (text.Substring(j, 4) == "</a>")
                    {
                        text = text.Remove(j, 4);
                        text = text.Insert(j, "[/URL]");
                        break;
                    }
                }
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
        Replace(text);
    }
}
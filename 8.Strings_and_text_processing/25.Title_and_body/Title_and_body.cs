//Write a program that extracts from given HTML file its title (if available),
//and its body text without the HTML tags.

using System;
using System.Text;

class HTML
{
    static int index;
    static void Title(string text)
    {
        int startIndex = 0;
        int endIndex = 0;

        for (int i = 0; i < text.Length - 8; i++)
        {
            if (text.Substring(i, 7) == "<title>")
            {
                startIndex = i + 7;
                i = startIndex;
            }
            if (text.Substring(i, 8) == "</title>")
            {
                endIndex = i;
                int length = endIndex - startIndex;
                string title = text.Substring(startIndex, length);
                Console.WriteLine("Title: ");
                Console.WriteLine(title);
                index = endIndex + 9;
            }
        }
    }
    static void Body(string text)
    {
        int startIndex = 0;
        int endIndex = 0;
        Console.WriteLine("Body:");
        for (int i = index; i < text.Length - 1; i++)
        {
            if (text.Substring(i, 1) == ">")
            {
                startIndex = i + 1;
                i = startIndex;
            }
            if (text.Substring(i, 1) == "<")
            {
                endIndex = i;
                int length = endIndex - startIndex;
                if (length > 0)
                {
                    string body = text.Substring(startIndex, length);
                    Console.Write(body + " ");
                }
            }
        }
    }
    static void Main()
    {
        StringBuilder builder = new StringBuilder();
        Console.WriteLine("Enter HTML:");
        string html;
        while (true)
        {
            html = Console.ReadLine().Trim();
            if (html != "")
            {
                builder.Append(html + " ");
            }
            else
            {
                break;
            }
        }
        html = builder.ToString();
        Console.WriteLine("Changed Text:");
        Title(html);
        Console.WriteLine();
        Body(html);
        Console.WriteLine();
    }
}
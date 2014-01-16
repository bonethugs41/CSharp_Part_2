//Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings. 

using System;

class UnicodeChracter
{
    static void Main()
    {
        Console.Title = "Convert string text to Unicode characters";
        Console.Write("Enter text: ");
        string text = Console.ReadLine();
        UnicodeChange(text);
    }

    private static void UnicodeChange(string text)
    {
        for (int i = 0; i < text.Length; i++)
        {
            Console.Write("\\u{0:x4}", (int)text[i]);
        }
    }
}

//Write a program that reads from the console a string of maximum 20 characters.
//If the length of the string is less than 20, the rest of the characters should be filled with '*'.
//Print the result string into the console.


using System;

class MaximumLength
{
    static void Main()
    {
        Console.Title = "Maximum 20 characters";
        Console.Write("Enter text with maximum 20 characters: ");
        string text;
        while (true)
        {
            text = Console.ReadLine();
            if (text.Length <= 20)
            {
                break;
            }
            else
            {
                Console.Write("Enter text with maximum 20 characters: ");
            }
        }
        Console.WriteLine();
        Console.WriteLine(text.PadRight(20, '*'));
    }
}
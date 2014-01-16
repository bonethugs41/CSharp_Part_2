//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

using System;

class AlphabeticalOrder
{
    static void Main()
    {
        Console.WriteLine("Enter string:");
        string text = Console.ReadLine();
        string[] parts = text.Split(' ');
        Array.Sort(parts);
        for (int i = 0; i < parts.Length; i++)
        {
            Console.WriteLine(parts[i]);
        }
    }
}
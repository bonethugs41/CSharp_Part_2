//Write a program that creates an array containing all letters from the alphabet (A-Z).
//Read a word from the console and print the index of each of its letters in the array.

using System;

class Letters
{
    static void Main()
    {
        char[] arr = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        Console.WriteLine("Enter some word: ");
        string word = Console.ReadLine();
        foreach (var letter in word)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (letter == arr[i])
                {
                    Console.WriteLine("{0} -> index[{1}]", letter, i);
                }
            }
        }
    }
}
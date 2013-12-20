//Write a program that compares two char arrays lexicographically (letter by letter).


using System;

class Lexicographically
{
    static void Main()
    {
        Console.Title = "Lexicographically compare";
        Console.Write("Input some text:");
        string firstArrayText = Console.ReadLine();
        Console.Write("Input some text again:");
        string secondArrayText = Console.ReadLine();

        char[] array1 = firstArrayText.ToCharArray();
        char[] array2 = secondArrayText.ToCharArray();

        if (array1.Length <= array2.Length)
        {
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] == array2[i])
                {
                    Console.WriteLine("{0} = {1}", array1[i], array2[i]);
                }
                else
                {
                    Console.WriteLine("{0} != {1}", array1[i], array2[i]);
                }
            }
        }
        else if (array1.Length > array2.Length)
        {
            for (int i = 0; i < array2.Length; i++)
            {
                if (array1[i] == array2[i])
                {
                    Console.WriteLine("{0} = {1}", array1[i], array2[i]);
                }
                else
                {
                    Console.WriteLine("{0} != {1}", array1[i], array2[i]);
                }
            }
        }
    }
}
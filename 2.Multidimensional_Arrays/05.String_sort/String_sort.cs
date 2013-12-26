//You are given an array of strings.
//Write a method that sorts the array by the length of its elements (the number of characters composing them).

using System;

class StringSort
{
    static void Main()
    {
        Console.Title = "String sorting";
        int n;
        while (true)
        {
            Console.WriteLine("Input N:");
            string check = Console.ReadLine();
            bool result = int.TryParse(check, out n);
            if (result == true && n > 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid number! Try again.");
            }
        }
        string[] array = new string[n];


    }
}
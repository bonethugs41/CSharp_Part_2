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
            Console.Write("Input N:");
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

        for (int i = 0; i < n; i++)
        {
            Console.Write("Element[{0}]: ", i);
            array[i] = Console.ReadLine();
        }

        string temp;
        int maxElement;
        for (int i = 0; i < n - 1; i++)
        {
            maxElement = i;
            for (int j = i + 1; j < n; j++)
            {
                if (array[j].Length < array[maxElement].Length)
                {
                    maxElement = j;
                }
            }
            if (maxElement != i)
            {
                temp = array[i];
                array[i] = array[maxElement];
                array[maxElement] = temp;
            }
        }
        Console.WriteLine("This is the sorted array:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Element[{0}]: {1} ", i, array[i]);
        }
    }
}
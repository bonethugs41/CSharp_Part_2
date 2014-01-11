//Write a program that generates and prints to the console 10 random values in the range [100, 200].


using System;

class RandomNumbers
{
    static void Main()
    {
        Console.Title = "10 random values";
        Random values = new Random();
        Console.WriteLine("10 random values in the range [100,200] ");
        Console.WriteLine("Press any key to generate them.");
        Console.ReadLine();
        for (int i = 0; i < 10; i++)
        {
            int randomValue = values.Next(100, 200);
            Console.Write("{0} ", randomValue);
        }
        Console.WriteLine();
    }
}
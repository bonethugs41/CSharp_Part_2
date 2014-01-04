//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is working correctly.


using System;

class RepeatArray
{
    static int IntegerCheck(string check)                                       //Check if the input information is integer
    {
        while (true)
        {
            int integer;
            bool result = int.TryParse(check, out integer);
            if (result == true)
            {
                return integer;
            }
            else
            {
                Console.Write("Invalid integer, try again: ");
                check = Console.ReadLine();
            }
        }
    }

    static void NumberToLookFor(int wantedNumber, int[] array)                  //Check how many times the number is repeated in the array
    {
        int counter = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == wantedNumber)
            {
                counter++;
            }
        }
        Console.WriteLine("{0} is repeated {1} times in the array.", wantedNumber, counter);
    }

    static void Main()
    {
        Console.Write("Input size of array: ");
        int arraySize = IntegerCheck(Console.ReadLine());
        int[] array = new int[arraySize];
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Element[{0}]: ", i);
            array[i] = IntegerCheck(Console.ReadLine());
        }
        Console.Write("Input integer to look for in the array: ");
        int wanted = IntegerCheck(Console.ReadLine());
        NumberToLookFor(wanted, array);
    }
}
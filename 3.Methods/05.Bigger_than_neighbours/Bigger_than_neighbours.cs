//Write a method that checks if the element at given position in given array of integers is bigger than its two neighbors (when such exist).


using System;

class BiggerNeighbours
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

    static void CheckBiggerNumber(int elementIndex, int[] array)                 //Checks if the current element is bigger than its two neighbors
    {
        bool check = false;
        if (elementIndex == 0)
        {
            if (array[elementIndex] > array[elementIndex + 1])
            {
                check = true;
            }
        }
        else if (elementIndex == array.Length - 1)
        {
            if (array[elementIndex] > array[elementIndex - 1])
            {
                check = true;
            }
        }
        else if (true)
        {
            if (array[elementIndex] > array[elementIndex + 1] && array[elementIndex] > array[elementIndex - 1])
            {
                check = true;
            }
        }
        if (check == true)
        {
            Console.WriteLine("The number at position {0} is bigger than its neighbours.", elementIndex);
        }
        else
        {
            Console.WriteLine("The number at position {0} is not bigger than its neighbours.", elementIndex);
        }

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
        Console.Write("Input the index of the element to check: ");
        int elementIndex = IntegerCheck(Console.ReadLine());
        CheckBiggerNumber(elementIndex, array);
    }
}
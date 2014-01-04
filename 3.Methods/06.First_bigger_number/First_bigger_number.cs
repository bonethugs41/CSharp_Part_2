//Write a method that returns the index of the first element in array that is bigger than its neighbors, or -1, if there’s no such element.



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

    static int CheckBiggerNumber(int[] array)                                 //Checks if the current element is bigger than its two neighbors
    {
        for (int index = 0; index < array.Length; index++)
        {
            if (index == 0)
            {
                if (array[index] > array[index + 1])
                {
                    return index;
                }
            }
            else if (index == array.Length)
            {
                if (array[index] > array[index - 1])
                {
                    return index;
                }
            }
            else if (array[index] > array[index - 1] && array[index] > array[index + 1])
            {
                return index;
            }
        }
        return -1;
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
        int elementIndex = CheckBiggerNumber(array);
        if (elementIndex == -1)
        {
            Console.WriteLine("There is no such integer in the array, that is bigger than its neighbours.");
        }
        else
        {
            Console.WriteLine("{0} is the first element in the array, that is greater than its neighbours.", elementIndex);
        }
    }
}
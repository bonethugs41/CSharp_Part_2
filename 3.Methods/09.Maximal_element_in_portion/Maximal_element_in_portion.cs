//Write a method that return the maximal element in a portion of array of integers starting at given index.
//Using it write another method that sorts an array in ascending / descending order.



using System;

class MaximalElement
{
    static int IntegerCheck(string check)                                       //Check if the input information is a valid integer
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

    static void Printing(int[] Array)
    {
        for (int i = 0; i < Array.Length; i++)
        {
            Console.WriteLine(Array[i]);
        }
    }

    static void MaxElement(int[] array)
    {
        int maxElement = int.MinValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= maxElement)
            {
                maxElement = array[i];
            }
        }
        Console.WriteLine(maxElement);
    }

    static void AscendingSort(int[] array)
    {
        int temp = 0;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] > array[j])
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }
        Printing(array);
    }

    static void DescendingSort(int[] array)
    {
        int temp = 0;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] < array[j])
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }
        Printing(array);
    }

    static void Main(string[] args)
    {
        Console.Write("Enter size of the array: ");
        int arraySize = IntegerCheck(Console.ReadLine());
        int[] array = new int[arraySize];
        for (int index = 0; index < array.Length; index++)
        {
            Console.Write("Enter value for element[{0}]: ", index);
            array[index] = IntegerCheck(Console.ReadLine());
        }

        int startPosition;
        while (true)                                                            //Check for a valid start position
        {
            Console.Write("Enter starting position: ");
            startPosition = IntegerCheck(Console.ReadLine());
            if (startPosition >= 0 && startPosition < array.Length)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Enter integer number for position >= 0 and < {0}: ", arraySize);
            }
        }
        
        //Initialization a portion array
        int portionArraySize = arraySize - startPosition;
        int[] portionArray = new int[portionArraySize];
        for (int i = 0; i < portionArray.Length; i++)
        {
            portionArray[i] = array[startPosition + i];
        }

        Console.WriteLine();
        Console.Write("The maximal element of the portion array is: ");
        MaxElement(portionArray);
        Console.WriteLine();
        Console.WriteLine("Ascending order:");
        AscendingSort(portionArray);
        Console.WriteLine();
        Console.WriteLine("Descending order:");
        DescendingSort(portionArray);

    }
}
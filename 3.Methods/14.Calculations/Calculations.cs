//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
//Use variable number of arguments.

using System;

class Calculations
{
    static void Sort(int[] array)
    {
        int temp;
        for (int j = 0; j < array.Length; j++)
        {
            for (int i = j + 1; i < array.Length; i++)
            {
                if ((array[j] < array[i]))
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }
        PrintArray(array);
    }
    static void MaxElement(int[] array)
    {
        Console.WriteLine(array[0]);
    }
    static void MinElement(int[] array)
    {
        Console.WriteLine(array[array.Length - 1]);
    }
    static void Average(int[] array)
    {
        double sum = 0;
        double average;
        for (int i = 0; i < array.Length; i++)
        {
            sum = sum + array[i];
        }
        average = sum / array.Length;
        Print(average);
    }
    static void Sum(int[] array)
    {
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum = sum + array[i];
        }
        Print(sum);
    }
    static void Product(int[] array)
    {
        long multiplication = 1;
        for (int i = 0; i < array.Length; i++)
        {
            multiplication = multiplication * array[i];
        }
        Print(multiplication);
    }
    static void Print(double target)
    {
        Console.WriteLine(target);
    }
    static void PrintArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
    static void Main()
    {
        Console.WriteLine("Enter number of integers:");
        int size;
        //Check size:
        while (true)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out size) && (size > 0))
            {
                break;
            }
            else
            {
                Console.Write("Invalid input. Enter integer number: ");
            }
        }
        Console.WriteLine("Enter {0} integers:", size);
        int[] arr = new int[size];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Integer numbers:");
        PrintArray(arr);
        Console.WriteLine();
        Console.WriteLine("Sorted array:");
        Sort(arr);
        Console.WriteLine();
        Console.WriteLine("Minimum, maximum, average, sum and product of this set of integer numbers:");
        Console.WriteLine();
        Console.Write("Minimum: ");
        MinElement(arr);
        Console.WriteLine();
        Console.Write("Maximum: ");
        MaxElement(arr);
        Console.WriteLine();
        Console.Write("Average: ");
        Average(arr);
        Console.WriteLine();
        Console.Write("Sum: ");
        Sum(arr);
        Console.WriteLine();
        Console.Write("Product: ");
        Product(arr);
        Console.WriteLine();

    }
}
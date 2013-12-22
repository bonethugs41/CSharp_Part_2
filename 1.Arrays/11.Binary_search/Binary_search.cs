//Write a program that finds the index of given element in a sorted array of integers
//by using the binary search algorithm (find it in Wikipedia).

using System;

class BinarySearch
{
    static void Main()
    {
        Console.WriteLine("Enter the Size of array N:");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        int index = 0;
        int minIndex = 0;
        int maxIndex = n;
        int midIndex;
        int replace;
        Console.WriteLine("Enter an Array of {0} elements:", n);
        for (int i = 0; i < n; i++)
        {
            Console.Write("Element[{0}]: ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Enter element: ");
        int element = int.Parse(Console.ReadLine());
        for (int j = 0; j < n; j++)
        {
            for (int i = j + 1; i < n; i++)
            {
                if (arr[j] > arr[i])
                {
                    replace = arr[i];
                    arr[i] = arr[j];
                    arr[j] = replace;
                }
            }
        }
        Console.WriteLine();
        Console.WriteLine("Sorted Array:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(arr[i]);
        }
        while (true)
        {
            midIndex = (maxIndex + minIndex) / 2;
            if (arr[midIndex] == element)
            {
                index = midIndex;
                break;
            }
            else if (arr[midIndex] > element)
            {
                maxIndex = midIndex;
            }
            else if (arr[midIndex] < element)
            {
                minIndex = midIndex;
            }
            else
            {
                Console.WriteLine("There is no such element in the array");
                break;
            }
        }
        Console.WriteLine(index);
    }
}
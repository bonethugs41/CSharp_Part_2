//Sorting an array means to arrange its elements in increasing order.
//Write a program to sort an array. Use the "selection sort" algorithm:
//Find the smallest element, move it at the first position,
//find the smallest from the rest, move it at the second position, etc.



using System;

class SortingArray
{
    static void Main()
    {
        Console.Title = "Sorting an Array";
        int n;
        while (true)
        {
            Console.Write("Enter the array length: ");
            string check = Console.ReadLine();
            bool result = int.TryParse(check, out n);
            if (result == true && n > 0)
            {
                break;
            }
        }

        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            while (true)
            {
                Console.Write("Enter element[{0}]: ", i);
                string check = Console.ReadLine();
                bool result = int.TryParse(check, out array[i]);
                if (result == true)
                {
                    break;
                }
            }
        }

        int temp;
        int minElement;
        for (int i = 0; i < n - 1; i++)
        {
            minElement = i;
            for (int j = i + 1; j < n; j++)
            {
                if (array[j] < array[minElement])
                {
                    minElement = j;
                }
            }
            if (minElement != i)
            {
                temp = array[i];
                array[i] = array[minElement];
                array[minElement] = temp;
            }
        }
        Console.WriteLine("This is the sorted array:");
        for (int i = 0; i < n; i++)
        {
            Console.Write("{0}   ", array[i]);
        }
        Console.WriteLine();
    }
}
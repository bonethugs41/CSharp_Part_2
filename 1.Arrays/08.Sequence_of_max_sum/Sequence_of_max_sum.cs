//Write a program that finds the sequence of maximal sum in given array.
//Example:	{2, 3, -6, -1, 2, -1, 6, 4, -8, 8} => {2, -1, 6, 4}
//	Can you do it with only one loop (with single scan through the elements of the array)?


using System;

class SequenceSum
{
    static void Main()
    {
        Console.Title = "Sequence of maximal sum";
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

        int maxSoFar = array[0];
        int maxEndingHere = array[0];
        int begin = 0;
        int begin_temp = 0;
        int end = 0;

        for (int i = 1; i < array.Length; i++)
        {
            if (maxEndingHere < 0)
            {
                maxEndingHere = array[i];
                begin_temp = i;
            }
            else
            {
                maxEndingHere += array[i];
            }
            if (maxEndingHere >= maxSoFar)
            {
                maxSoFar = maxEndingHere;
                begin = begin_temp;
                end = i;
            }
        }

        for (int i = begin; i <= end; i++)
        {
            Console.Write("{0} ", array[i]);
        }
        Console.WriteLine();
        Console.WriteLine("Sum = {0}", maxSoFar);
    }
}


// I have used the Kadane's algorithm, which you can find in wikipedia.

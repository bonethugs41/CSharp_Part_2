//Write a program that finds the maximal increasing sequence in an array. 
//          Example: {3, 2, 3, 4, 2, 2, 4} => {2, 3, 4}.


using System;

class IncreasingSequence
{
    static void Main()
    {
        Console.Title = "Increasing sequence";
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
            while (true)                                            //will aks until successful parse
            {
                Console.Write("Element with index {0}: ", i);
                string check = Console.ReadLine();
                bool result = int.TryParse(check, out array[i]);
                if (result == true)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please input an integer!");
                }
            }
        }

        int count = 1;
        int index = 0;
        int tempcount = 1;

        for (int i = 1; i < n; i++)
        {
            if (array[i] == array[i - 1] + 1)
            {
                tempcount++;
                if (tempcount > count)
                {
                    count = tempcount;
                    index = i;
                }
            }
            else
            {
                tempcount = 1;
            }
        }

        Console.Write("Sub array is: ");
        for (int i = count - 1; i >= 0; i--)
        {
            Console.Write(array[index - i] + " ");
        }
        Console.WriteLine();
    }
}
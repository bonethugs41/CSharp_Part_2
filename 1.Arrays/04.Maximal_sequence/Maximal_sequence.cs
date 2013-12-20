//Write a program that finds the maximal sequence of equal elements in an array.
//		Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1} => {2, 2, 2}.



using System;

class MaximalSequence
{
    static void Main()
    {
        Console.Title = "Maximal Sequence";
        int n;
        while (true)                                                 //will aks until successful parse
        {
            Console.Write("Enter the array length:");
            string check = Console.ReadLine();
            bool result = int.TryParse(check, out n);
            if (result == true)
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
        

        int repeatNumber = 0;
        int count = 1;

        for (int index = 0; index < array.Length - 1; index++)
        {
            if (array[index] == array[index + 1])
            {
                repeatNumber = index;
                count++;
            }
        }
        Console.Write("The maximal equal sequence is: ");
        for (int i = 0; i < count; i++)
        {
            Console.Write(array[repeatNumber] + " ");
        }
        Console.WriteLine();
    }
}

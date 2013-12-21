//Write a program that reads two integer numbers N and K and an array of N elements from the console. 
//Find in the array those K elements that have maximal sum.


using System;

class MaximalSum
{
    static void Main()
    {
        Console.Title = "Maximal sum in array";
        int n;
        int k;

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

        while (true)
        {
            Console.Write("Input K: ");
            string check = Console.ReadLine();
            bool result = int.TryParse(check, out k);
            if (result == true && k > 0)
            {
                break;
            }
        }

        if (n < k)
        {
            Console.WriteLine("N must be bigger than K!");
            return;
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
        Array.Sort(array);
        int sum = 0;
        int m = 0;
        for (int i = 0; i <= k - 1; i++)
        {
            sum = sum + array[(n - 1) - m];
            m = m + 1;
        }
        Console.WriteLine("The maximal sum with K elements is: {0}", sum);

    }
}
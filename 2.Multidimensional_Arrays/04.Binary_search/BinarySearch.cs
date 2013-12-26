//Write a program, that reads from the console an array of N integers and an integer K,
//sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K. 


using System;

class BinarySearch
{
    static void Main()
    {
        Console.Title = "Binary search";
        int n;
        while (true)
        {
            Console.WriteLine("Input N:");
            string check = Console.ReadLine();
            bool result = int.TryParse(check, out n);
            if (result == true && n > 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid number! Try again.");
            }
        }

        int k;
        while (true)
        {
            Console.WriteLine("Input K:");
            string check = Console.ReadLine();
            bool result = int.TryParse(check, out k);
            if (result == true)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid number! Try again.");
            }
        }
        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            while (true)
            {
                Console.Write("Element[{0}]: ", i);
                string check = Console.ReadLine();
                bool result = int.TryParse(check, out array[i]);
                if (result == true)
                {
                    break;
                }
            }
        }

        Array.Sort(array);

        int target = k;
        int index = -1;

        while (index < 0)
        {
            index = Array.BinarySearch(array, target);
            target--;
        }

        Console.WriteLine("The biggest number <= K is: {0}", array[index]);
    }
}
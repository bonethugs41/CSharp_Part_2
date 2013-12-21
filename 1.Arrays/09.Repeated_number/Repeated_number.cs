//Write a program that finds the most frequent number in an array.
//Example:	{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3} => 4 (5 times)



using System;

class RepeatedNumber
{
    static void Main()
    {
        Console.Title = "Repeated number";
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
                Console.Write("Element with index {0}: ", i);
                string check = Console.ReadLine();
                bool result = int.TryParse(check, out array[i]);
                if (true)
                {
                    break;
                }
            }
        }

        int count = 0;
        int tempcount = 0;
        int indexOfRepeat = 0;

        for (int i = 0; i < array.Length; i++)
        {
            foreach (var element in array)
            {
                if (element == array[i])
                {
                    count = count + 1;
                }
            }
            if (tempcount < count)
            {
                tempcount = count;
                indexOfRepeat = array[i];
            }
            count = 0;
        }
        Console.WriteLine("{0} is repeated {1} times.", indexOfRepeat, tempcount);
    }
}
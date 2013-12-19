//Write a program that reads two arrays from the console and compares them element by element.


using System;

class TwoArrays
{
    static void Main()
    {
        Console.Title = "Compare arrays";
        
        int arraySize;
        while (true)                                                                //array size
        {
            Console.Write("Enter the size of the two arrays:");
            string check = Console.ReadLine();
            bool result = int.TryParse(check, out arraySize);
            if (result == true && arraySize > 0)
            {
                break;
            }
        }
        int[] arr1 = new int[arraySize];
        int[] arr2 = new int[arraySize];

        for (int i = 0; i < arraySize; i++)                                          //input cycle for array 1
        {
            while (true)
            {
                Console.Write("Element of Array 1 with index {0}:", i);
                string check = Console.ReadLine();
                bool result = int.TryParse(check, out arr1[i]);
                if (result == true)
                {
                    break;
                }
            }
        }

        for (int i = 0; i < arraySize; i++)                                          //input cycle for array 2
        {
            while (true)
            {
                Console.Write("Element of Array 2 with index {0}:", i);
                string check = Console.ReadLine();
                bool result = int.TryParse(check, out arr2[i]);
                if (result == true)
                {
                    break;
                }
            }
        }

        for (int i = 0; i < arr1.Length; i++)                                            //compare cycle and output
        {
            if (arr1[i] == arr2[i])
            {
                Console.WriteLine("{0} = {0}", arr1[i], arr2[i]);
            }
            if (arr1[i] > arr2[i])
            {
                Console.WriteLine("{0} > {0}", arr1[i], arr2[i]);
            }
            if (arr1[i] < arr2[i])
            {
                Console.WriteLine("{0} < {0}", arr1[i], arr2[i]);
            }
        }
    }
}
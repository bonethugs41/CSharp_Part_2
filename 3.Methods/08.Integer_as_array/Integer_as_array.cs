//Write a method that adds two positive integer numbers represented as arrays of digits
//(each array element arr[i] contains a digit; the last digit is kept in arr[0]).
//Each of the numbers that will be added could have up to 10 000 digits.

using System;

class ArraysOfDigits
{
    static void Add(int[] arr1, int[] arr2)
    {
        int remainder = 0;
        int[] arrAddFirstSecond = new int[arr2.Length];

        for (int i = 0; i < arr1.Length; i++)
        {
            arrAddFirstSecond[i] = arr1[i] + arr2[i] + remainder;
            remainder = 0;
            if (arrAddFirstSecond[i] > 9)
            {
                remainder = arrAddFirstSecond[i] / 10;
                arrAddFirstSecond[i] = arrAddFirstSecond[i] % 10;
            }
        }
        for (int i = arr1.Length; i < arrAddFirstSecond.Length; i++)
        {
            arrAddFirstSecond[i] = arr2[i] + remainder;
            remainder = 0;
            if (arrAddFirstSecond[i] > 9)
            {
                if (i == arrAddFirstSecond.Length - 1)
                {
                    break;
                }
                remainder = arrAddFirstSecond[i] / 10;
                arrAddFirstSecond[i] = arrAddFirstSecond[i] % 10;
            }
        }
        Console.WriteLine();
        Print(arrAddFirstSecond);
    }
    static void Print(int[] arr)
    {
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(arr[i]);
        }
    }
    static void Main()
    {
        int temp;
        Console.WriteLine("Enter size of the first number:");
        int smallerNumberSize = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter size of the second number:");
        int biggerNumberSize = int.Parse(Console.ReadLine());
        //Check bigger size:
        if (smallerNumberSize >= biggerNumberSize)
        {
            temp = biggerNumberSize;
            biggerNumberSize = smallerNumberSize;
            smallerNumberSize = temp;
        }
        //Initializing arrays:
        int[] arrFirstNumber = new int[smallerNumberSize];
        Console.WriteLine("Enter array of number with {0} digits:", smallerNumberSize);
        for (int i = arrFirstNumber.Length - 1; i >= 0; i--)
        {
            arrFirstNumber[i] = int.Parse(Console.ReadLine());
        }

        int[] arrSecondNumber = new int[biggerNumberSize];
        Console.WriteLine("Enter array of number with {0} digits:", biggerNumberSize);
        for (int i = arrSecondNumber.Length - 1; i >= 0; i--)
        {
            arrSecondNumber[i] = int.Parse(Console.ReadLine());
        }
        Add(arrFirstNumber, arrSecondNumber);
    }
}
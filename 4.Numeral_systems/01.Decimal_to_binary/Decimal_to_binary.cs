//Write a program to convert decimal numbers to their binary representation.


using System;

class DecimalBinary
{
    static bool isNegative = false;
    static int IntegerCheck(string check)                                       //Check if the input information is integer
    {
        while (true)
        {
            int integer;
            bool result = int.TryParse(check, out integer);
            if (result == true)
            {
                return integer;
            }
            else
            {
                Console.Write("Invalid integer, try again: ");
                check = Console.ReadLine();
            }
        }
    }

    static void Converter(int number)
    {
        int remainder;
        int[] array = new int[32];
        for (int i = 0; i < array.Length; i++)
        {
            remainder = number % 2;
            number = number / 2;
            array[i] = remainder;
        }
        ReverseArray(array);
    }
   

    static void ReverseArray(int[] array)                                       
    {
        int temp;
        if (isNegative == false)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                temp = array[i];
                array[i] = array[array.Length - i - 1];
                array[array.Length - i - 1] = temp;
            }
        }
        else
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                temp = array[i];
                array[i] = array[array.Length - i - 1];
                array[array.Length - i - 1] = temp;
            }
            array[0] = 1;
        }
        Printig(array);
    }

    static void Printig(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
        }
        Console.WriteLine();
    }

    static void Main()
    {
        Console.Title = "Decimal to binary converter";
        Console.Write("Input some number: ");
        int number = IntegerCheck(Console.ReadLine());
        if (number < 0)
        {
            number = Int32.MaxValue + number + 1;
            isNegative = true;
        }
        Converter(number);
    }
}
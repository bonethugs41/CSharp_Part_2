//Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
//Format the output aligned right in 15 symbols.


using System;

class Convert_number
{
    static void Main()
    {
        Console.Write("Enter integer:");
        int number;
        while (true)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out number))
            {
                break;
            }
            else
            {
                Console.Write("Invalid input. Enter integer: ");
            }
        }
        Console.WriteLine("Number {0} as decimal number:", number);
        Console.WriteLine("{0,15:D}", number);
        Console.WriteLine("Number {0} as hexadecimal number:", number);
        Console.WriteLine("{0,15:X}", number);
        Console.WriteLine("Number {0} as percentage:", number);
        Console.WriteLine("{0,15:P}", number);
        Console.WriteLine("Number {0} in scientific notation:", number);
        Console.WriteLine("{0,15:E}", number);
    }
}
//Write a method that returns the last digit of given integer as an English word.
//Examples: 512 => "two", 1024 => "four", 12309 => "nine".


using System;

class LastDigitName
{
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

    static string CheckLastDigit(int lastDigit)                                 //Check the last digit
    {
        int digit = lastDigit % 10;
        switch (digit)
        {
            case 0:
                {
                    return "Zero";
                }
            case 1:
                {
                    return "One";
                }
            case 2:
                {
                    return "Two";
                }
            case 3:
                {
                    return "Three";
                }
            case 4:
                {
                    return "Four";
                }
            case 5:
                {
                    return "Five";
                }
            case 6:
                {
                    return "Six";
                }
            case 7:
                {
                    return "Seven";
                }
            case 8:
                {
                    return "Eight";
                }
            case 9:
                {
                    return "Nine";
                }
            default:
                return "ups";
        }
    }

    static void Main()
    {
        Console.Write("Input an integer: ");
        int number = IntegerCheck(Console.ReadLine());
        string digitName = CheckLastDigit(number);
        Console.WriteLine("The last digit is {0}", digitName);
    }
}
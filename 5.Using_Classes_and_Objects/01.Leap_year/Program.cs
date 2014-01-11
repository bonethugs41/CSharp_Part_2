//Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.


using System;

class LeapYear
{
    static int IntegerCheck(string check) //Check if the input information is integer
    {
        while (true)
        {
            int integer;
            bool result = int.TryParse(check, out integer);
            if (result == true && integer > 0)
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

    private static bool IsLeapYear(int year)
    {
        bool isLeap = DateTime.IsLeapYear(year);
        if (isLeap == true)
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    static void Main()
    {
        Console.Write("Enter an year: ");
        int year = IntegerCheck(Console.ReadLine());
        bool isLeap = IsLeapYear(year);
        if (isLeap == true)
        {
            Console.WriteLine("{0} is a leap year.", year);
        }
        else
        {
            Console.WriteLine("{0} is not a leap year.", year);
        }
    }
}
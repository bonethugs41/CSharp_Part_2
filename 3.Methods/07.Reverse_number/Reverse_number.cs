//Write a method that reverses the digits of given decimal number. 
//Example: 256 => 652


using System;

class ReverseNumber
{
    static int DecimalCheck(string check)                                       //Check if the input information is decimal
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

    static int PrintReversedDigit(int number)                                   //This works for integers only          
    {
        int result = 0;
        int reverse = number;
        while (reverse > 0)
        {
            int r = reverse % 10;
            result = result * 10 + r;
            reverse = reverse / 10;
        }
        return result;
    }

    static void Main()
    {
        Console.Write("Input an integer:");
        int number = DecimalCheck(Console.ReadLine());
        int reversedNumber = PrintReversedDigit(number);
        Console.WriteLine("The reversed number is: {0}", reversedNumber);
    }
}

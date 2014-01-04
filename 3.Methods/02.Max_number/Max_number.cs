//Write a method GetMax() with two parameters that returns the bigger of two integers.
//Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().

using System;

class BiggestInteger
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

    static int GetMax(int firstNumber, int secondNumber)                        //Finds bigger of two integers
    {
        if (firstNumber >= secondNumber)
        {
            return firstNumber;
        }
        else
        {
            return secondNumber;
        }
    }

    static void Main()
    {
        Console.WriteLine("Enter 3 integers:");
        int firstNumber = IntegerCheck(Console.ReadLine());
        int secondNumber = IntegerCheck(Console.ReadLine());
        int thirdNumber = IntegerCheck(Console.ReadLine());
        int compare = GetMax(firstNumber, secondNumber);
        int biggest = GetMax(compare, thirdNumber);
        Console.WriteLine("The biggest number is: {0}", biggest);
    }
}
//Write a program that can solve these tasks:
//Reverses the digits of a number
//Calculates the average of a sequence of integers
//Solves a linear equation a * x + b = 0
//  - Create appropriate methods.
//  - Provide a simple text-based menu for the user to choose which task to solve.
//  - Validate the input data:
//      The decimal number should be non-negative
//      The sequence should not be empty
//      "a" should not be equal to 0

using System;

class TaskToSolve
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
                Console.Write("Invalid number, try again: ");
                check = Console.ReadLine();
            }
        }
    }

    static void Main()
    {
        Console.WriteLine("Choose which task to solve:");
        Console.WriteLine(@" - Enter 1 for ""Reverse the digits of a number""");
        Console.WriteLine(@" - Enter 2 for ""Calculate the average of a sequence of integers""");
        Console.WriteLine(@" - Enter 3 for ""Solve a linear equation a * x + b = 0""");

        while (true)
        {
            int n = IntegerCheck(Console.ReadLine());
            if (n == 1 || n == 2 || n == 3)
            {
                break;
            }
            else
            {
                Console.Write("Invalid number, try again: ");
            }
        }
    }
}


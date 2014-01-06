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

    static double DoubleCheck(string check)                                       //Check if the input information is double
    {
        while (true)
        {
            double integer;
            bool result = double.TryParse(check, out integer);
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

    static void Printing(int[] array)                                           //Prints array elements
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
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

    static double Average(int[] array)                                          //Gives the average sum of integers
    {
        double sum = 0;
        double average = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum = sum + array[i];
        }
        average = sum / array.Length;
        Printing(array);
        return average;
    }

    static double LinearEquation(double a, double b)                            //Solves a linear equation
    {
        double x = (-b) / a;
        return x;
    }

    static void Main()
    {
        Console.WriteLine("Choose which task to solve:");
        Console.WriteLine(@" - Enter 1 for ""Reverse the digits of a number""");
        Console.WriteLine(@" - Enter 2 for ""Calculate the average of a sequence of integers""");
        Console.WriteLine(@" - Enter 3 for ""Solve a linear equation a * x + b = 0""");

        int n;
        while (true)
        {
            n = IntegerCheck(Console.ReadLine());
            if (n == 1 || n == 2 || n == 3)
            {
                break;
            }
            else
            {
                Console.Write("Invalid number, try again: ");
            }
        }

        switch (n)
        {
            case    1:
                {
                    Console.Write("Input an integer:");
                    int number = IntegerCheck(Console.ReadLine());
                    int reversedNumber = PrintReversedDigit(number);
                    Console.WriteLine("The reversed number is: {0}", reversedNumber);
                    break;
                }
            case    2:
                {
                    Console.Write("Enter the number of integers: ");
                    int arraySize = IntegerCheck(Console.ReadLine());
                    int[] array = new int[arraySize];
                    for (int i = 0; i < array.Length; i++)
                    {
                        array[i] = IntegerCheck(Console.ReadLine());
                    }
                    Console.WriteLine("The average sum of array is: {0}", Average(array));
                    break;
                }
            case    3:
                {
                    Console.Write("Enter coefficient a != 0: ");
                    double a;
                    while (true)
                    {
                        a = DoubleCheck(Console.ReadLine());
                        if (a != 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.Write("a should be != 0, try again: ");
                        }
                    }
                    Console.Write("Enter coefficient b: ");
                    double b = DoubleCheck(Console.ReadLine());
                    Console.WriteLine("{0}*x + {1} = 0", a, b);
                    Console.WriteLine("x={0}", LinearEquation(a, b));
                    break;
                }
        }

    }
}


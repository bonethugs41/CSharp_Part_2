//Write a program that reads an integer number and calculates and prints its square root.
//If the number is invalid or negative, print "Invalid number". 
//In all cases finally print "Good bye". Use try-catch-finally.


using System;


class Program
{
    static void SquareRoot(int number)
    {
        if (number < 0)
        {
            throw new System.ArgumentOutOfRangeException("Integer has to be possitive!");
        }
        Console.WriteLine(Math.Sqrt(number));
    }

    static void Main(string[] args)
    {
        try
        {
            int number = int.Parse(Console.ReadLine());
            try
            {
                SquareRoot(number);
            }
            catch (ArgumentOutOfRangeException ae)
            {

                Console.WriteLine(ae.Message);
            }
        }
        catch (FormatException)
        {

            Console.WriteLine("Invalid number!");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Invalid number!");
        }
        finally
        {
            Console.WriteLine("Good bye!");

        }
    }
}

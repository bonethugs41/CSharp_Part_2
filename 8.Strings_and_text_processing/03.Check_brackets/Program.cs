//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d).
//Example of incorrect expression: )(a+b)).




using System;

class Program
{
    static void Main()
    {
        Console.Title = "Check the brackets!";
        Console.Write("Write an expression: ");
        string expression = Console.ReadLine();
        bool check = CheckTheBrackets(expression);
        if (check == true)
        {
            Console.WriteLine("The expression is correct!");
        }
        else
        {
            Console.WriteLine("The expression is not correct");
        }
    }

    private static bool CheckTheBrackets(string expression)                             //Don't know how to make it work for ")a+b("
    {
        bool check = false;
        int counter = 0;
        for (int i = 0; i < expression.Length; i++)
        {
            if (expression[i] == '(')
            {
                counter++;
            }
            else if (expression[i] == ')')
            {
                counter--;
            }
        }
        if (counter == 0)
        {
            check = true;
            return check;
        }
        else
        {
            return check;
        }
    }
}
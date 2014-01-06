using System;

class BinaryDecimal
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

    static int Converter(string biNumber)
    {
        int sum = 0;
        int index = 0;
        int power = 1;
        for (int i = biNumber.Length - 1; i >= 0; i--)
        {
            if (biNumber[i] == '0')
            {
                index++;
                continue;
            }
            else if (biNumber[i] == '1')
            {
                for (int j = 0; j < index; j++)                             
                {
                    power = power * 2;
                }
                //power = (int)Math.Pow(2, index);
                sum = sum + power;
                index++;
                power = 1;
            }

        }
        return sum;
    }

    static void Printing(int result)
    {
        Console.WriteLine("The number is: {0}", result);
    }

    static void Main()
    {
        Console.Title = "Binary to decimal convertor";
        Console.Write("Enter a binary number: ");
        int number = IntegerCheck(Console.ReadLine());
        string biNumber = number.ToString();
        int result = Converter(biNumber);
        Printing(result);
    }
}
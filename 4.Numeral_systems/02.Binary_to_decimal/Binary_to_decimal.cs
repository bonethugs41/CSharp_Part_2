using System;

class BinaryDecimal
{
    static void StringToArray(string biNumber, byte[] arrayOfBits)
    {
        for (int bit = 0; bit < arrayOfBits.Length; bit++)
        {
            if (biNumber[bit] == '0')
            {
                arrayOfBits[bit] = 0;
            }
            else
            {
                arrayOfBits[bit] = 1;
            }
        }
        //To check if the array element are corect
        //for (int i = 0; i < 8; i++)
        //{
        //    Console.Write(arrayOfBits[i] + " ");
        //}
    }

    static int ConvertToDecimalNumber(byte[] array)
    {
        int index = 0;
        int power = 1;
        int sum = 0;
        for (int bit = array.Length - 1; bit >= 0; bit--)
        {
            if (array[bit] == 0)
            {
                index++;
                continue;
            }
            else if (array[bit] == 1)
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
        if (array[0] == 0)
        {
            return sum;
        }
        else
        {
            sum = sum - byte.MaxValue - 1;
            return sum;
        }
    }

    static void Printing(int result)
    {
        Console.WriteLine("The number is: {0}", result);
    }

    static void Main()
    {
        Console.Title = "Binary to decimal convertor";
        Console.Write("Enter an 8-bit binary number: ");
        string biNumber = Console.ReadLine();
        byte[] arrayOfBits = new byte[8];
        StringToArray(biNumber, arrayOfBits);
        int decNumber = ConvertToDecimalNumber(arrayOfBits);
        Console.WriteLine("The decimal number is: {0}", decNumber);
    }
}
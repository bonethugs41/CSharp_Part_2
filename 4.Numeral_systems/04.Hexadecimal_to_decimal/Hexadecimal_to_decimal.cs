//Write a program to convert hexadecimal numbers to their decimal representation.

using System;

class HexadecimalToDecimal
{
    static int HexToDec(string hexNumber)
    {
        int power = 1;
        int index = 0;
        int sum = 0;
        for (int i = hexNumber.Length - 1; i >= 0; i--)
        {
            switch (hexNumber[i])
            {
                case '0':
                    index++;
                    break;
                case '1':
                    power = 1 * (int)Math.Pow(16, index);
                    sum = sum + power;
                    index++;
                    break;
                case '2':
                    power = 2 * (int)Math.Pow(16, index);
                    sum = sum + power;
                    index++;
                    break;
                case '3':
                    power = 3 * (int)Math.Pow(16, index);
                    sum = sum + power;
                    index++;
                    break;
                case '4':
                    power = 4 * (int)Math.Pow(16, index);
                    sum = sum + power;
                    index++;
                    break;
                case '5':
                    power = 5 * (int)Math.Pow(16, index);
                    sum = sum + power;
                    index++;
                    break;
                case '6':
                    power = 6 * (int)Math.Pow(16, index);
                    sum = sum + power;
                    index++;
                    break;
                case '7':
                    power = 7 * (int)Math.Pow(16, index);
                    sum = sum + power;
                    index++;
                    break;
                case '8':
                    power = 8 * (int)Math.Pow(16, index);
                    sum = sum + power;
                    index++;
                    break;
                case '9':
                    power = 9 * (int)Math.Pow(16, index);
                    sum = sum + power;
                    index++;
                    break;
                case 'A':
                    power = 10 * (int)Math.Pow(16, index);
                    sum = sum + power;
                    index++;
                    break;
                case 'B':
                    power = 11 * (int)Math.Pow(16, index);
                    sum = sum + power;
                    index++;
                    break;
                case 'C':
                    power = 12 * (int)Math.Pow(16, index);
                    sum = sum + power;
                    index++;
                    break;
                case 'D':
                    power = 13 * (int)Math.Pow(16, index);
                    sum = sum + power;
                    index++;
                    break;
                case 'E':
                    power = 14 * (int)Math.Pow(16, index);
                    sum = sum + power;
                    index++;
                    break;
                case 'F':
                    power = 15 * (int)Math.Pow(16, index);
                    sum = sum + power;
                    index++;
                    break;
            }
        }
        return sum;
    }
    static void Print(int sum)
    {
        Console.WriteLine("Decimal Number is:");
        Console.WriteLine(sum);
    }
    static void Main()
    {
        Console.WriteLine("Enter some Hexadecimal number:");
        string hexNumber = Console.ReadLine();
        hexNumber = hexNumber.ToUpper();
        int number = HexToDec(hexNumber);
        Print(number);
    }
}
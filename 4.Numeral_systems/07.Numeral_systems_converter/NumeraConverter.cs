//Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤ 16).

using System;

class ConvertNumeralSystems
{
    static int SToDec(string sNumber, int baseS)
    {
        int power = 1;
        int index = 0;
        int sum = 0;
        int numValue = -1;
        for (int i = sNumber.Length - 1; i >= 0; i--)
        {

            // ToInt32 can throw FormatException or OverflowException.
            try
            {
                numValue = Convert.ToInt32(sNumber[i]) - 48;
            }
            catch (FormatException e)
            {
                Console.WriteLine("Input string is not a sequence of digits.");
            }
            catch (OverflowException e)
            {
                Console.WriteLine("The number cannot fit in an Int32.");
            }
            if (numValue == 0)
            {
                index++;
                continue;
            }
            else
            {
                power = numValue * (int)Math.Pow(baseS, index);
                sum = sum + power;
                index++;
            }
        }
        return sum;
    }
    static void Print(int sum)
    {
        Console.WriteLine("Decimal Number is:");
        Console.WriteLine(sum);
    }

    static int index;
    static void DecToD(int number, int baseD)
    {
        int remainder;
        int[] strRemainder = new int[32];
        for (int i = 0; i < strRemainder.Length; i++)
        {
            remainder = number % baseD;
            number = number / baseD;
            strRemainder[i] = remainder;
            if (number / baseD == 1)
            {
                remainder = number % baseD;
                number = number / baseD;
                strRemainder[i + 1] = remainder;
                strRemainder[i + 2] = number;
                index = i + 2;
                break;
            }
            else if (number / baseD == 0)
            {
                remainder = number % baseD;
                strRemainder[i + 1] = remainder;
                index = i + 1;
                break;
            }
        }

        ReverseArray(strRemainder);
        Hexadecimal(strRemainder);
    }
    static void ReverseArray(int[] array)
    {
        Array.Reverse(array);
    }
    static void Hexadecimal(int[] array)
    {
        string[] strRemainder = new string[32];
        for (int i = 0; i < strRemainder.Length; i++)
        {
            switch (array[i])
            {
                case 0:
                    strRemainder[i] = "0";
                    break;
                case 1:
                    strRemainder[i] = "1";
                    break;
                case 2:
                    strRemainder[i] = "2";
                    break;
                case 3:
                    strRemainder[i] = "3";
                    break;
                case 4:
                    strRemainder[i] = "4";
                    break;
                case 5:
                    strRemainder[i] = "5";
                    break;
                case 6:
                    strRemainder[i] = "6";
                    break;
                case 7:
                    strRemainder[i] = "7";
                    break;
                case 8:
                    strRemainder[i] = "8";
                    break;
                case 9:
                    strRemainder[i] = "9";
                    break;
                case 10:
                    strRemainder[i] = "A";
                    break;
                case 11:
                    strRemainder[i] = "B";
                    break;
                case 12:
                    strRemainder[i] = "C";
                    break;
                case 13:
                    strRemainder[i] = "D";
                    break;
                case 14:
                    strRemainder[i] = "E";
                    break;
                case 15:
                    strRemainder[i] = "F";
                    break;
            }
        }
        PrintArray(strRemainder);

    }
    static void PrintArray(string[] arr)
    {
        for (int i = 32 - (index + 1); i < 32; i++)
        {
            Console.Write(arr[i]);
        }
    }
    static void Main()
    {
        Console.WriteLine("Enter numeral system of base s (2 ≤ s): ");
        int baseS = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter numeral system of base d (d ≤ 16): ");
        int baseD = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number in {0} numeral system:", baseS);
        string sNumber = Console.ReadLine();
        int number = SToDec(sNumber, baseS);
        Print(number);
        Console.WriteLine("Number in {0} numeral system is:", baseD);
        DecToD(number, baseD);
        Console.WriteLine();
    }
}
//Write a program to convert decimal numbers to their hexadecimal representation.


using System;

class DecimalHexadecimal
{
    static bool isNegative = false;
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

    static void DecimalToHexConverter(int decNumber)
    {
        int remainder;
        byte[] array = new byte[8];
        for (int i = 0; i < array.Length; i++)
        {
            remainder = decNumber % 16;
            decNumber = decNumber / 16;
            array[i] = (byte)remainder;
        }
        ReverseArray(array);
    }

    static void ReverseArray(byte[] array)
    {
        byte temp;
        if (isNegative == false)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                temp = array[i];
                array[i] = array[array.Length - i - 1];
                array[array.Length - i - 1] = temp;
            }
        }
        else
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                temp = array[i];
                array[i] = array[array.Length - i - 1];
                array[array.Length - i - 1] = temp;
            }
            array[0] = 1;
        }
        Hexadecimal(array);
    }

    static void Hexadecimal(byte[] array)
    {
        string[] hexArray = new string[8];
        for (int i = 0; i < hexArray.Length; i++)
        {
            switch (array[i])
            {
                case 0:
                    hexArray[i] = "0";
                    break;
                case 1:
                    hexArray[i] = "1";
                    break;
                case 2:
                    hexArray[i] = "2";
                    break;
                case 3:
                    hexArray[i] = "3";
                    break;
                case 4:
                    hexArray[i] = "4";
                    break;
                case 5:
                    hexArray[i] = "5";
                    break;
                case 6:
                    hexArray[i] = "6";
                    break;
                case 7:
                    hexArray[i] = "7";
                    break;
                case 8:
                    hexArray[i] = "8";
                    break;
                case 9:
                    hexArray[i] = "9";
                    break;
                case 10:
                    hexArray[i] = "A";
                    break;
                case 11:
                    hexArray[i] = "B";
                    break;
                case 12:
                    hexArray[i] = "C";
                    break;
                case 13:
                    hexArray[i] = "D";
                    break;
                case 14:
                    hexArray[i] = "E";
                    break;
                case 15:
                    hexArray[i] = "F";
                    break;
            }
        }
        Printing(array);
    }

    private static void Printing(byte[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
        }
    }

    static void Main()
    {
        Console.Title = "Decimal to Hexadecimal converter";
        Console.Write("Input a 8-bit decimal number: ");
        int decNumber = IntegerCheck(Console.ReadLine());
        //byte[] decArray = new byte[8];
        if (decNumber < 0)
        {
            isNegative = true;
        }
        DecimalToHexConverter(decNumber);
    }
}
//Write a program to convert hexadecimal numbers to binary numbers (directly).

using System;

class HexadecimalToBinary
{
    static string HexToBin(string hexNumber)
    {
        string binNumber = "";
        for (int i = 0; i < hexNumber.Length; i++)
        {
            switch (hexNumber[i])
            {
                case '0':
                    binNumber = binNumber + "0000";
                    break;
                case '1':
                    binNumber = binNumber + "0001";
                    break;
                case '2':
                    binNumber = binNumber + "0010";
                    break;
                case '3':
                    binNumber = binNumber + "0011";
                    break;
                case '4':
                    binNumber = binNumber + "0100";
                    break;
                case '5':
                    binNumber = binNumber + "0101";
                    break;
                case '6':
                    binNumber = binNumber + "0110";
                    break;
                case '7':
                    binNumber = binNumber + "0111";
                    break;
                case '8':
                    binNumber = binNumber + "1000";
                    break;
                case '9':
                    binNumber = binNumber + "1001";
                    break;
                case 'A':
                    binNumber = binNumber + "1010";
                    break;
                case 'B':
                    binNumber = binNumber + "1011";
                    break;
                case 'C':
                    binNumber = binNumber + "1100";
                    break;
                case 'D':
                    binNumber = binNumber + "1101";
                    break;
                case 'E':
                    binNumber = binNumber + "1110";
                    break;
                case 'F':
                    binNumber = binNumber + "1111";
                    break;
            }
        }
        return binNumber;
    }
    static void Print(string sum)
    {
        Console.WriteLine("Binary Number is:");
        Console.WriteLine(sum);
    }
    static void Main()
    {
        Console.WriteLine("Enter some Hexadecimal number:");
        string hexNumber = Console.ReadLine();
        hexNumber = hexNumber.ToUpper();
        string number = HexToBin(hexNumber);
        Print(number);
    }
}
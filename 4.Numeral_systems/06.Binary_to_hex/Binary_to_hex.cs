//Write a program to convert binary numbers to hexadecimal numbers (directly).

using System;

class BinaryToHexadecimal
{
    static string BinToHex(string binNumber)
    {
        string hexNumber = "";
        string subString = "";
        for (int i = 0; i < binNumber.Length; i = i + 4)
        {
            for (int j = 0; j < 4; j++)
            {
                subString = subString + binNumber[i + j];
            }
            switch (subString)
            {
                case "0000":
                    hexNumber = hexNumber + "0";
                    break;
                case "0001":
                    hexNumber = hexNumber + "1";
                    break;
                case "0010":
                    hexNumber = hexNumber + "2";
                    break;
                case "0011":
                    hexNumber = hexNumber + '3';
                    break;
                case "0100":
                    hexNumber = hexNumber + '4';
                    break;
                case "0101":
                    hexNumber = hexNumber + '5';
                    break;
                case "0110":
                    hexNumber = hexNumber + '6';
                    break;
                case "0111":
                    hexNumber = hexNumber + '7';
                    break;
                case "1000":
                    hexNumber = hexNumber + '8';
                    break;
                case "1001":
                    hexNumber = hexNumber + '9';
                    break;
                case "1010":
                    hexNumber = hexNumber + 'A';
                    break;
                case "1011":
                    hexNumber = hexNumber + 'B';
                    break;
                case "1100":
                    hexNumber = hexNumber + 'C';
                    break;
                case "1101":
                    hexNumber = hexNumber + 'D';
                    break;
                case "1110":
                    hexNumber = hexNumber + 'E';
                    break;
                case "1111":
                    hexNumber = hexNumber + 'F';
                    break;
            }
            subString = "";
        }
        return hexNumber;
    }
    static void Print(string sum)
    {
        Console.WriteLine("Hexadecimal Number is:");
        Console.WriteLine(sum);
    }
    static void Main()
    {
        Console.WriteLine("Enter some Binary number:");
        string binNumber = Console.ReadLine();
        string number = BinToHex(binNumber);
        Print(number);
    }
}


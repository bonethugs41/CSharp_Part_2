//Write a program to convert decimal numbers to their hexadecimal representation.


using System;

class DecimalHexadecimal
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

    static int[] DecimalToHexadecimal(int decNumber)
    {
        int remainder;
        int index = 0;
        int[] arrayRemainder = new int[32];
        for (int i = 0; i < arrayRemainder.Length; i++)
        {
            remainder = decNumber % 16;
            decNumber = decNumber / 16;
            arrayRemainder[i] = remainder;
            if (decNumber / 16 == 1)
            {
                remainder = decNumber % 16;
                decNumber = decNumber / 16;
                arrayRemainder[i + 1] = remainder;
                arrayRemainder[i + 2] = decNumber;
                index = i + 2;
                break;
            }
            else if (decNumber / 16 == 0)
            {
                remainder = decNumber % 16;
                arrayRemainder[i + 1] = remainder;
                index = i + 1;
                break;
            }
        }
        return arrayRemainder;
    }

    static void ReverseArray(int[] array)
    {
        int temp;
            for (int i = 0; i < array.Length / 2; i++)
            {
                temp = array[i];
                array[i] = array[array.Length - i - 1];
                array[array.Length - i - 1] = temp;
            }
        Hexadecimal(array);
    }

    private static string[] Hexadecimal(int[] array)
    {
        string[] hexArray = new string[32];
        for (int i = 0; i < hexArray.Length; i++)
        {
            switch (array[i])
            {
                case 0:
                    {
                        hexArray[i] = "0";
                        break;
                    }

                case 1:
                    {
                        hexArray[i] = "1";
                        break;
                    }

                case 2:
                    {
                        hexArray[i] = "2";
                        break;
                    }
                case 3:
                    {
                        hexArray[i] = "3";
                        break;
                    }

                case 4:
                    {
                        hexArray[i] = "4";
                        break;
                    }

                case 5:
                    {
                        hexArray[i] = "5";
                        break;
                    }

                case 6:
                    {
                        hexArray[i] = "6";
                        break;
                    }

                case 7:
                    {
                        hexArray[i] = "7";
                        break;
                    }

                case 8:
                    {
                        hexArray[i] = "8";
                        break;
                    }

                case 9:
                    {
                        hexArray[i] = "9";
                        break;
                    }

                case 10:
                    {
                        hexArray[i] = "A";
                        break;
                    }

                case 11:
                    {
                        hexArray[i] = "B";
                        break;
                    }

                case 12:
                    {
                        hexArray[i] = "C";
                        break;
                    }

                case 13:
                    {
                        hexArray[i] = "D";
                        break;
                    }

                case 14:
                    {
                        hexArray[i] = "E";
                        break;
                    }

                case 15:
                    {
                        hexArray[i] = "F";
                        break;
                    }

            }
        }
        return hexArray;
    }

    private static void Printig(string[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
        }
        Console.WriteLine();
    }

    static void Main()                                                          //Works only with positive numbers..
    {
        Console.Title = "Decimal to Hexadecimal converter";
        Console.Write("Input a 8-bit decimal positive number: ");
        int decNumber = IntegerCheck(Console.ReadLine());
        int[] array = DecimalToHexadecimal(decNumber);
        ReverseArray(array);
        string[] hexArray = Hexadecimal(array);
        Printig(hexArray);
    }
}
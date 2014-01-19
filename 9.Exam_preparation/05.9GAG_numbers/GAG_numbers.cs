using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _05._9GAG_numbers
{
    class GagNumbers
    {
        static string ConvertGagString(string digit)
        {
            string result = "NO";
            switch (digit)
            {
                case "-!": return "0"; break;
                case "**": return "1"; break;
                case "!!!": return "2"; break;
                case "&&": return "3"; break;
                case "&-": return "4"; break;
                case "!-": return "5"; break;
                case "*!!!": return "6"; break;
                case "&*!": return "7"; break;
                case "!!**!-": return "8"; break;

                default:
                    break;
            }
            return result;
        }

        //static BigInteger HexToDec(string hexNumber)
        //{
        //    long power = 1;
        //    long index = 0;
        //    BigInteger sum = 0;
        //    for (int i = hexNumber.Length - 1; i >= 0; i--)
        //    {
        //        switch (hexNumber[i])
        //        {
        //            case '0':
        //                index++;
        //                break;
        //            case '1':
        //                power = 1 * (long)Math.Pow(9, index);
        //                sum = sum + power;
        //                index++;
        //                break;
        //            case '2':
        //                power = 2 * (long)Math.Pow(9, index);
        //                sum = sum + power;
        //                index++;
        //                break;
        //            case '3':
        //                power = 3 * (long)Math.Pow(9, index);
        //                sum = sum + power;
        //                index++;
        //                break;
        //            case '4':
        //                power = 4 * (long)Math.Pow(9, index);
        //                sum = sum + power;
        //                index++;
        //                break;
        //            case '5':
        //                power = 5 * (long)Math.Pow(9, index);
        //                sum = sum + power;
        //                index++;
        //                break;
        //            case '6':
        //                power = 6 * (long)Math.Pow(9, index);
        //                sum = sum + power;
        //                index++;
        //                break;
        //            case '7':
        //                power = 7 * (long)Math.Pow(9, index);
        //                sum = sum + power;
        //                index++;
        //                break;
        //            case '8':
        //                power = 8 * (long)Math.Pow(9, index);
        //                sum = sum + power;
        //                index++;
        //                break;
        //            case '9':
        //                power = 9 * (long)Math.Pow(9, index);
        //                sum = sum + power;
        //                index++;
        //                break;
        //        }
        //    }
        //    return sum;
        //}

        static BigInteger NinePower(int number)
        {
            BigInteger result = 1;
            for (int i = 0; i < number; i++)
            {
                result = result * 9;
            }
            return result;
        }

        static void Main()
        {
            string input = Console.ReadLine();
            string partialInput = string.Empty;
            string nineSystemNumber = "";

            for (int i = 0; i < input.Length; i++)
            {
                partialInput = partialInput + input[i];
                string currentDigit = ConvertGagString(partialInput);

                if (currentDigit != "NO")
                {
                    nineSystemNumber += currentDigit;
                    partialInput = "";
                }
            }

            BigInteger result = 0;

            for (int i = 0; i < nineSystemNumber.Length; i++)
            {
                BigInteger digit = int.Parse(nineSystemNumber[i].ToString());
                //result = result + digit * (int)Math.Pow(9, nineSystemNumber.Length  - 1 - i);

                result = result + digit * NinePower(nineSystemNumber.Length - 1 - i);
            }
            Console.WriteLine(result);
        }
    }
}

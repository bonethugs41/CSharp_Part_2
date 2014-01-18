using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Multiverse_communication
{
    class MultiverseCommunication
    {
        static long[] decodedMessage;
        static void Main()
        {
            string input = Console.ReadLine();
            string[] inputArray = new string[input.Length / 3];
            int move = 0;

            for (int i = 0; i < inputArray.Length; i++)
            {
                inputArray[i] = input.Substring(move, 3);
                move = move + 3;
            }
            ConvertMessage(inputArray);
            Console.WriteLine(HexToDec(decodedMessage));
        }

        private static long HexToDec(long[] decodedMessage)
        {
            long power = 1;
            long index = 0;
            long sum = 0;

            for (int i = decodedMessage.Length - 1; i >= 0; i--)
            {
                switch (decodedMessage[i])
                {
                    case 0:
                        index++;
                        break;
                    case 1:
                        power = 1 * (long)Math.Pow(13, index);
                        sum = sum + power;
                        index++;
                        break;
                    case 2:
                        power = 2 * (long)Math.Pow(13, index);
                        sum = sum + power;
                        index++;
                        break;
                    case 3:
                        power = 3 * (long)Math.Pow(13, index);
                        sum = sum + power;
                        index++;
                        break;
                    case 4:
                        power = 4 * (long)Math.Pow(13, index);
                        sum = sum + power;
                        index++;
                        break;
                    case 5:
                        power = 5 * (long)Math.Pow(13, index);
                        sum = sum + power;
                        index++;
                        break;
                    case 6:
                        power = 6 * (long)Math.Pow(13, index);
                        sum = sum + power;
                        index++;
                        break;
                    case 7:
                        power = 7 * (long)Math.Pow(13, index);
                        sum = sum + power;
                        index++;
                        break;
                    case 8:
                        power = 8 * (long)Math.Pow(13, index);
                        sum = sum + power;
                        index++;
                        break;
                    case 9:
                        power = 9 * (long)Math.Pow(13, index);
                        sum = sum + power;
                        index++;
                        break;
                    case 10:
                        power = 10 * (long)Math.Pow(13, index);
                        sum = sum + power;
                        index++;
                        break;
                    case 11:
                        power = 11 * (long)Math.Pow(13, index);
                        sum = sum + power;
                        index++;
                        break;
                    case 12:
                        power = 12 * (long)Math.Pow(13, index);
                        sum = sum + power;
                        index++;
                        break;
                    default: throw new ArgumentException();
                }
            }
            return sum;
        }

        private static void ConvertMessage(string[] inputArray)
        {
            decodedMessage = new long[inputArray.Length];

            for (int i = 0; i < inputArray.Length; i++)
            {
                switch (inputArray[i])
                {
                    case "CHU": decodedMessage[i] = 0; break;
                    case "TEL": decodedMessage[i] = 1; break;
                    case "OFT": decodedMessage[i] = 2; break;
                    case "IVA": decodedMessage[i] = 3; break;
                    case "EMY": decodedMessage[i] = 4; break;
                    case "VNB": decodedMessage[i] = 5; break;
                    case "POQ": decodedMessage[i] = 6; break;
                    case "ERI": decodedMessage[i] = 7; break;
                    case "CAD": decodedMessage[i] = 8; break;
                    case "K-A": decodedMessage[i] = 9; break;
                    case "IIA": decodedMessage[i] = 10; break;
                    case "YLO": decodedMessage[i] = 11; break;
                    case "PLA": decodedMessage[i] = 12; break;
                    default: throw new ArgumentException();
                }
            }
        }
    }
}

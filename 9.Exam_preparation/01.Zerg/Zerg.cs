using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Zerg
{
    class Zerg
    {
        static long[] convertedMessage;
        static void ConvertZergMessageToInteger(string[] current)
        {
            convertedMessage = new long[current.Length];
            for (long i = 0; i < current.Length; i++)
            {
                switch (current[i])
                {
                    case "Rawr": convertedMessage[i] = 0; break;
                    case "Rrrr": convertedMessage[i] = 1; break;
                    case "Hsst": convertedMessage[i] = 2; break;
                    case "Ssst": convertedMessage[i] = 3; break;
                    case "Grrr": convertedMessage[i] = 4; break;
                    case "Rarr": convertedMessage[i] = 5; break;
                    case "Mrrr": convertedMessage[i] = 6; break;
                    case "Psst": convertedMessage[i] = 7; break;
                    case "Uaah": convertedMessage[i] = 8; break;
                    case "Uaha": convertedMessage[i] = 9; break;
                    case "Zzzz": convertedMessage[i] = 10; break;
                    case "Bauu": convertedMessage[i] = 11; break;
                    case "Djav": convertedMessage[i] = 12; break;
                    case "Myau": convertedMessage[i] = 13; break;
                    case "Gruh": convertedMessage[i] = 14; break;
                    default: throw new ArgumentException();
                }
            }
        }

        static long HexToDec(long[] hexNumber)
        {
            long power = 1;
            long index = 0;
            long sum = 0;
            for (long i = hexNumber.Length - 1; i >= 0; i--)
            {
                switch (hexNumber[i])
                {
                    case 0:
                        index++;
                        break;
                    case 1:
                        power = 1 * (long)Math.Pow(15, index);
                        sum = sum + power;
                        index++;
                        break;
                    case 2:
                        power = 2 * (long)Math.Pow(15, index);
                        sum = sum + power;
                        index++;
                        break;
                    case 3:
                        power = 3 * (long)Math.Pow(15, index);
                        sum = sum + power;
                        index++;
                        break;
                    case 4:
                        power = 4 * (long)Math.Pow(15, index);
                        sum = sum + power;
                        index++;
                        break;
                    case 5:
                        power = 5 * (long)Math.Pow(15, index);
                        sum = sum + power;
                        index++;
                        break;
                    case 6:
                        power = 6 * (long)Math.Pow(15, index);
                        sum = sum + power;
                        index++;
                        break;
                    case 7:
                        power = 7 * (long)Math.Pow(15, index);
                        sum = sum + power;
                        index++;
                        break;
                    case 8:
                        power = 8 * (long)Math.Pow(15, index);
                        sum = sum + power;
                        index++;
                        break;
                    case 9:
                        power = 9 * (long)Math.Pow(15, index);
                        sum = sum + power;
                        index++;
                        break;
                    case 10:
                        power = 10 * (long)Math.Pow(15, index);
                        sum = sum + power;
                        index++;
                        break;
                    case 11:
                        power = 11 * (long)Math.Pow(15, index);
                        sum = sum + power;
                        index++;
                        break;
                    case 12:
                        power = 12 * (long)Math.Pow(15, index);
                        sum = sum + power;
                        index++;
                        break;
                    case 13:
                        power = 13 * (long)Math.Pow(15, index);
                        sum = sum + power;
                        index++;
                        break;
                    case 14:
                        power = 14 * (long)Math.Pow(15, index);
                        sum = sum + power;
                        index++;
                        break;
                }
            }
            return sum;
        }

        static void Main()
        {
            string zergMessage = Console.ReadLine();
            string[] stringMessage = new string[zergMessage.Length / 4];
            int move = 0;
            for (int i = 0; i < stringMessage.Length; i++)
            {
                stringMessage[i] = zergMessage.Substring(move, 4);
                move = move + 4;
            }
            ConvertZergMessageToInteger(stringMessage);
            Console.WriteLine(HexToDec(convertedMessage)); 
        }
    }
}
//GruhGruhGruhGruhGruhGruhGruhGruhGruh
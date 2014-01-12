//Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different.
//Assume the files have equal number of lines.


using System;
using System.IO;

class Program
{
    static void Main()
    {
        string[] firstText = File.ReadAllLines("../../text1.txt");
        string[] secondText = File.ReadAllLines("../../text2.txt");
        int counter = 0;
        int differentCounter = 0;
        for (int i = 0; i < firstText.Length; i++)
        {
            if (firstText[i] == secondText[i])
            {
                counter++;
            }
            else
            {
                differentCounter++;
            }
        }
        Console.WriteLine("Number of lines that are same is: {0}", counter);
        Console.WriteLine("Number of lines that are different is: {0}", differentCounter);
    }
}
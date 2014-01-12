//Write a program that concatenates two text files into another text file.


using System;
using System.IO;

class MergeFiles
{
    static void Main()
    {
        Console.Title = "Merging text files";
        string firstFile = File.ReadAllText("../../Terran.txt");
        string secondFIle = File.ReadAllText("../../Protoss.txt");

        StreamWriter writer = File.CreateText("../../Combine.txt");
        using (writer)
        {
            writer.Write(firstFile + Environment.NewLine + secondFIle);
            Console.WriteLine("The concatenation is successful");
        }
    }
}
//Write a program that reads a text file and prints on the console its odd lines.


using System;
using System.IO;

class OddLines
{
    static void Main()
    {
        Console.Title = "Reading text files";
        StreamReader reader = new StreamReader(@"../../ReadingFile.cs");
        using (reader)
        {
            int lineNumber = 0;
            string line = reader.ReadLine();
            while (line != null)
            {
                lineNumber++;
                if (lineNumber % 2 == 1)
                {
                    Console.WriteLine("Line {0}: {1}", lineNumber, line);
                }
                line = reader.ReadLine();
            }
        }
    }
}
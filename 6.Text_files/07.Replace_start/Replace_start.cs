//Write a program that replaces all occurrences of the substring "start" with the substring "finish" in a text file.
//Ensure it will work with large files (e.g. 100 MB).


using System;
using System.IO;

class ReplaceStart
{
    static void Main()
    {
        StreamReader readText = new StreamReader("../../start.txt");
        StreamWriter writeText = new StreamWriter("../../finish.txt");
        using (readText)
        {
            using (writeText)
            {
                string line = readText.ReadLine();
                while (line != null)
                {
                    string newLine = line.Replace("start", "finish");
                    writeText.WriteLine(newLine);
                    line = readText.ReadLine();
                }
            }
        }
        Console.WriteLine("Complete!");
    }
}
//Write a program that reads a text file and inserts line numbers in front of each of its lines. 
//The result should be written to another text file.


using System;
using System.IO;

class InsertLine
{
    static void Main()
    {
        Console.Title = " Inserting line numbers";
        StreamReader readText = new StreamReader("../../Terran.txt");
        StreamWriter writeText = new StreamWriter("../../newText.txt");
        using (readText)
        {
            using (writeText)
            {
                int counter = 1;
                string currentLine;
                while ((currentLine = readText.ReadLine()) != null)
                {
                    writeText.WriteLine("[{0}] - {1}", counter, currentLine);
                    counter++;
                }
                Console.WriteLine("Complete!");
            }
        }
    }
}
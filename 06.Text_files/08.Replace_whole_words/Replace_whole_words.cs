//Modify the solution of the previous problem to replace only whole words (not substrings).


using System;
using System.IO;
using System.Text.RegularExpressions;

class ReplaceWholeWords
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
                    string newLine = Regex.Replace(line, @"\bstart\b", "finish");
                    writeText.WriteLine(newLine);
                    line = readText.ReadLine();
                }
            }
        }
        Console.WriteLine("Complete!");
    }
}
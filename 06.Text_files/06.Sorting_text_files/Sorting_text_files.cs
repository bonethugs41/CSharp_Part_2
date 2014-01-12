//Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.
//Example:
//	Ivan			George
//	Peter	==> 	Ivan
//	Maria			Maria
//	George			Peter



using System;
using System.IO;
using System.Linq;

class SortingFiles
{
    static void Main()
    {
        string[] textLines = File.ReadAllLines("../../input.txt").ToArray();
        Array.Sort(textLines);
        File.WriteAllLines("../../output.txt", textLines);
        Console.WriteLine("Complete!");

    }
}
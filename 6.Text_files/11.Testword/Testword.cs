//Write a program that deletes from a text file all words that start with the prefix "test".
//Words contain only the symbols 0...9, a...z, A…Z, _.


using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

class Testword
{
    static void Main()
    {
        string testFile = File.ReadAllText("../../test.txt");
        File.WriteAllText("../../test.txt", Regex.Replace(testFile, @"\b(test\w*)\b", String.Empty));
        Console.WriteLine("Complete!");
    }
}
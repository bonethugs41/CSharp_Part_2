//Write a program that reads a string, reverses it and prints the result at the console.
//Example: "sample" => "elpmas".


using System;

class Program
{
    static void Main()
    {
        Console.Title = "Reverse a string";
        Console.Write("Write some text: ");
        string s = Console.ReadLine();
        string reverseString = ReverseString(s);
        Console.WriteLine(reverseString);
    }

    private static string ReverseString(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
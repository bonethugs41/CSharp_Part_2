//Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
//Display them in the standard date format for Canada.

using System;
using System.Globalization;
using System.Text.RegularExpressions;

class ExtractDates
{
    static void Main()
    {
        CultureInfo culture = new CultureInfo("en-CA");
        Console.WriteLine("Enter text:");
        string text = Console.ReadLine();
        Console.WriteLine();
        const string MatchDatePattern = @"\b\d{2}.\d{2}.\d{4}\b";
        Regex rx = new Regex(MatchDatePattern);
        MatchCollection matches = rx.Matches(text);
        Console.WriteLine("Dates:");
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value.ToString());
        }
    }
}
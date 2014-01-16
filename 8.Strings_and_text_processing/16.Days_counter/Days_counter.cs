//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.

using System;
using System.Globalization;

class NumberOfDays
{
    static void Main()
    {
        Console.WriteLine("Enter two dates:");
        string text1 = Console.ReadLine();
        string text2 = Console.ReadLine();
        string format = "d.MM.yyyy";
        DateTime firstDate = DateTime.ParseExact(text1, format, CultureInfo.InvariantCulture);
        DateTime secondDate = DateTime.ParseExact(text2, format, CultureInfo.InvariantCulture);
        TimeSpan days = secondDate - firstDate;
        Console.WriteLine("Number of days between them:");
        Console.WriteLine(days.TotalDays);
    }
}
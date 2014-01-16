//Write a program that reads a date and time given in the format:
//day.month.year hour:minute:second and prints the date and time after
//6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.

using System;
using System.Globalization;
using System.Threading;

class PrintDateAndTimeAfter
{
    static void Main()
    {
        Console.WriteLine("Enter date and time in the format: day.month.year hour:minute:second:");
        string text = Console.ReadLine();
        string format = "d.M.yyyy HH:mm:ss";
        CultureInfo culture = new CultureInfo("bg-BG");

        DateTime dateAndTime = DateTime.ParseExact(text, format, culture);
        dateAndTime = dateAndTime + TimeSpan.Parse("06:30:00");
        Console.WriteLine("Date and Time after 6 hours & 30 minutes:");
        Console.WriteLine(dateAndTime);
        Console.WriteLine(dateAndTime.DayOfWeek);
    }
}
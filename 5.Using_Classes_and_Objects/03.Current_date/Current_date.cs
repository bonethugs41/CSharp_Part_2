//Write a program that prints to the console which day of the week is today. Use System.DateTime


using System;

class CurrentDay
{
    static void Main()
    {
        DayOfWeek day = DateTime.Today.DayOfWeek;
        Console.WriteLine("Today is {0}.", day);
    }
}
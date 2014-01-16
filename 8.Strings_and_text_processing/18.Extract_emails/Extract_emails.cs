//Write a program for extracting all email addresses from given text.
//All substrings that match the format <identifier>@<host>…<domain> should be recognized as emails.
//Example:
//Please contact us by phone (+359 222 222 222) or by email example@abv.bg or at
//baj.ivan@yahoo.co.uk. This is not email:test@test. This also:@telerik.com. Neither this: a@a.b.


using System;
using System.Text.RegularExpressions;

class Email
{
    static void Main()
    {
        Console.WriteLine("Enter text:");
        string text = Console.ReadLine();
        Console.WriteLine();
        const string MatchEmailPattern =
@"(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
+ @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
  + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
+ @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})";
        Regex rx = new Regex(MatchEmailPattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);
        MatchCollection matches = rx.Matches(text);
        int noOfMatches = matches.Count;
        Console.WriteLine("Emails:");
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value.ToString());
        }
    }
}
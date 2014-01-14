//Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg)
//and stores it the current directory. Find in Google how to download files in C#.
//Be sure to catch all exceptions and to free any used resources in the finally block.


using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile("http://img.photo-forum.net/site_pics/120/1389199625_IMG_0981-2.jpg", @"../../pic.jpg");
        }
        catch (WebException)
        {
            Console.WriteLine("Remote server returned error: Forbidden.");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Address cannot null.");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("The method has been called simultaneously on multiple threads.");
        }
    }
}
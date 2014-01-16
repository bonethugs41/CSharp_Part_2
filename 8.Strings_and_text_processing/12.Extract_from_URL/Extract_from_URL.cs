//Write a program that parses an URL address given in the format:
//[protocol]://[server]/[resource]
//and extracts from it the [protocol], [server] and [resource] elements. 
//For example from the URL http://www.devbg.org/forum/index.php the following information should be extracted:
	//	[protocol] = "http"
	//	[server] = "www.devbg.org"
	//	[resource] = "/forum/index.php"


using System;
using System.Text.RegularExpressions;

class ExtractURL
{
    static void Main()
    {
        string url;
        Console.Write("Enter URL address: ");
        while (true)
        {
            url = Console.ReadLine();
            var format = Regex.Match(url, "(.*)://(.*?)(/.*)");
            if (format.Success)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Try again!");
            }
        }
        string[] parts = url.Split('/', '/');
        string[] cleanParts = new string[parts.Length - 1];
        int index = 0;
        for (int i = 0; i < parts.Length; i++)
        {
            if (parts[i] == "")
            {
                continue;
            }
            cleanParts[index] = parts[i];
            index++;
        }
        Console.WriteLine("[protocol] = \"{0}\"", cleanParts[0]);
        Console.WriteLine("[server] = \"{0}\"", cleanParts[1]);
        Console.WriteLine("[resource] = \"/{0}/{1}\"", cleanParts[2], cleanParts[3]);
    }
}
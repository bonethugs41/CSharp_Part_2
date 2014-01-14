//Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini),
//reads its contents and prints it on the console. Find in MSDN how to use System.IO.File.ReadAllText(…). 
//Be sure to catch all possible exceptions and print user-friendly error messages.


using System;
using System.IO;
using System.Security;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter file address. There is a default file. To access, just type: ../../test.exe");
        string Address = Console.ReadLine(); //"../../test.txt";
        string contents = null;
        try
        {
            contents = System.IO.File.ReadAllText(Address);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("1");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Argument exception. Enter valid path.");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("Path too long.");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Dierctory not found");
        }
        catch (IOException)
        {
            Console.WriteLine("5");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Access denied");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("Not supported file");
        }
        catch (SecurityException)
        {
            Console.WriteLine("8");
        }
        Console.WriteLine(contents);
    }
}
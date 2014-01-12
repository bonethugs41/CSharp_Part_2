//Write a program that extracts from given XML file all the text without the tags.


using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class XMLExtract
{
    static void Main()
    {
        string line = null;
        List<string> xmlValues = new List<string>();
        using (StreamReader reader = new StreamReader("../../XML.xml"))
        {
            while ((line = reader.ReadLine()) != null)
            {
                for (int i = 0; i < line.Length; i++)
                {
                    if (i < line.Length - 1 && line[i] == '>' && line[i + 1] != '<')
                    {
                        int startingIndex = i + 1;
                        int wordLength = 0;
                        while (line[i] != '<')
                        {
                            wordLength++;
                            i++;
                        }
                        xmlValues.Add(line.Substring(startingIndex, wordLength - 1));
                    }
                }
            }
        }
        for (int i = 0; i < xmlValues.Count; i++)
        {
            Console.WriteLine("{0}: {1}", i + 1, xmlValues[i]);
        }
    }
}
//Write a program that extracts from a given text all sentences containing given word.
//Consider that the sentences are separated by "." and the words – by non-letter symbols.


using System;

class WordInSentences
{
    static void Main()
    {
        Console.Title = "Finding a sentences containing given word";
        string text = @"We are living in a yellow submarine.
                        We don't have anything else.
                        Inside the submarine is very tight.
                        So we are drinking all the day.
                        We will move out of it in 5 days.";

        Console.Write("Enter word: ");
        string word = Console.ReadLine();
        Console.WriteLine();
        SearchWord(text, word);
    }

    private static void SearchWord(string text, string word)
    {
        string[] sentences = text.Split('.');
        string sent;
        for (int i = 0; i < sentences.Length; i++)
        {
            sent = sentences[i].ToLower();
            int index = sent.IndexOf(" " + word + " ");
            if (index > -1)
            {
                Console.WriteLine(sentences[i].Trim() + ".");
            }
        }
    } 
}
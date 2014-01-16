//Write a program that encodes and decodes a string using given encryption key (cipher).
//The key consists of a sequence of characters. 
//The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key,
//the second – with the second, etc. When the last key character is reached, the next is the first.


using System;

class EncodeDecode

{
    static void Main()
    {
        Console.Title = "XOR";
        Console.Write("Enter a word: ");
        string text = Console.ReadLine();
        Console.Write("Enter an encryption key: ");
        string key = Console.ReadLine();
        ushort[] convertedText = new ushort[text.Length];
        ushort[] convertedKey = new ushort[key.Length];
        ushort[] encrypt = new ushort[text.Length];
        int index = 0;
        Console.WriteLine("\nEncoded word: ");
        for (int i = 0; i < key.Length; i++)
        {
            convertedKey[i] = (ushort)key[i];
        }
        for (int i = 0; i < text.Length; i++)
        {
            convertedText[i] = (ushort)text[i];
            encrypt[i] = (ushort)(convertedText[i] ^ convertedText[index]);
            index++;
            if (index == convertedKey.Length)
            {
                index = 0;
            }
            Console.Write("\\u{0:x4}", encrypt[i]);
        }

    }
}
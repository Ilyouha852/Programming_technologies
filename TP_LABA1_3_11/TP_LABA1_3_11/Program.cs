using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string word1 = "";
        while (word1 == "")
        {
            Console.Write("Введите первое слово: ");
            word1 = Console.ReadLine();
        }

        string word2 = "";
        while (word2 == "")
        {
            Console.Write("Введите второе слово: ");
            word2 = Console.ReadLine();
        }

        string msg = Logic.haveSameLetters(word1, word2);
        Console.Write(msg);
    }
}

public class Logic
{
    public static string haveSameLetters(string word1, string word2)
    {
        string msg = "";
        HashSet<char> uniqueChars = new HashSet<char>(word1);

        foreach (char ch in uniqueChars)
        {
            if (word2.Contains(ch)) msg += "да ";
            else msg += "нет ";
        }

        return msg;
    }    
} 

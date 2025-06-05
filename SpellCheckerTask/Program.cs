using static System.Formats.Asn1.AsnWriter;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System;
namespace SpellCheckerTask

{
    class Program

{
    static void Main(string[] args)
    {

        string[] All = File.ReadAllLines("WordsFile.txt");
        string first = All[0].ToLower();
        string second = All[1].ToLower();
        string third = All[2].ToLower();
        string fourth = All[3].ToLower();
        string fifth = All[4].ToLower();
        Console.Write("Enter one word: ");
        string inputWord = Console.ReadLine().ToLower();

        if (inputWord == first || inputWord == second || inputWord == third || inputWord == fourth || inputWord == fifth)
        {Console.WriteLine("Correct!");}
        else {Console.WriteLine("Incorrect.");}
        

        Console.Write("Enter a sentence.");
        string sentence = Console.ReadLine().ToLower();
        string[] sentenceWords = sentence.Split(' ');

        int totalWords = 0;
        int correctWords = 0;

        foreach (string word in sentenceWords)
        {
            totalWords++;

            if (word == first || word == second || word == third || word == fourth || word == fifth)
            {
                correctWords++;
            }
        }

        double score = (double)correctWords / totalWords * 100;
        Console.WriteLine("\nCorrect words: " + correctWords + "/" + totalWords);
        Console.WriteLine("Spelling Score: " + score + "%");
    }
        static string[] createDictionary()
        {
            using StreamReader words = new("WordsFile.txt");
            int count = 0;
            string[] dictionaryData = new string[178636];
            while (!words.EndOfStream)
            {

                dictionaryData[count] = words.ReadLine();
                count++;
            }
            words.Close();
            return dictionaryData;
        }
}
}

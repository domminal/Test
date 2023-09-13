using System;

class Program
{
    static void Main()
    {
        string sentence = "Good Morning Teacher";
        string[] words = sentence.Split(' ');

        string revertedSentence = "";

        foreach (string word in words)
        {
            string reversedWord = "";
            int wordLength = word.Length;

            for (int i = wordLength - 1; i >= 0; i--)
            {
                reversedWord += word[i];
            }

            revertedSentence += reversedWord + " ";
        }

        revertedSentence = revertedSentence.TrimEnd();

        Console.WriteLine("ประโยคที่ revert : " + revertedSentence);
    }
}

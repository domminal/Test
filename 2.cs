using System;
using System.Linq;

class Program
{
    static bool IsAnagram(string s1, string s2)
    {
        if (s1.Length != s2.Length)
        {
            return false;
        }

        char[] chars1 = s1.ToLower().ToCharArray();
        char[] chars2 = s2.ToLower().ToCharArray();

        Array.Sort(chars1);
        Array.Sort(chars2);

        return new string(chars1) == new string(chars2);
    }

    static void Main()
    {
        string s1 = "Listen";
        string s2 = "Silent";

        if (IsAnagram(s1, s2))
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }
}

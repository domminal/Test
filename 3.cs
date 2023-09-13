using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] input = { 1, 2, 3, 4, 5, 7, 8, 9, 10, 14, 15, 16, 18, 22, 6 };

        Array.Sort(input);
        List<string> range = new List<string>();
        int min = input[0];
        int max = input[0];

        for (int i = 1; i < input.Length; i++)
        {
            if (input[i] == max + 1)
            {
                max = input[i];
            }
            else
            {
                if (min != max)
                {
                    range.Add(min + "-" + max);
                }
                else
                {
                    range.Add(min.ToString());
                }
                min = input[i];
                max = input[i];
            }
        }

        if (min != max)
        {
            range.Add(min + "-" + max);
        }
        else
        {
            range.Add(min.ToString());
        }

        Console.WriteLine(string.Join(",", range));
    }
}

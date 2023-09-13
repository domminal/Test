using System;

class Program
{
    static void Main()
    {
        int max = 4;
        int start = 1;

        for (int i = 1; i <= max; i++)
        {
            int end = start + i - 1;

            for (int j = start; j <= end; j++)
            {
                Console.Write(j);
                if (j < end)
                {
                    Console.Write(' ');
                }
            }

            if (i < max)
            {
                Console.WriteLine();
            }
            start = end + 1;
        }
    }
}

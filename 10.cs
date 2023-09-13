using System;

class Program
{
    static void Main()
    {
        int loop = 4;
        int h;
        int i;
        int j;
        j = loop;
        for (h = loop; h >= 1; h--)
        {
            j++;
            for (i = 1; i <= j; i++)
            {
                Console.Write(" ");
            }
            for (i = 1; i <= h; i++)
            {
                Console.Write("*");
            }
            for (i = h - 1; i >= 1; i--)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}

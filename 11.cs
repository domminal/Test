using System;

class Program
{
    static void Main()
    {
        int[] values = { 1, 2, 9, 4, 5, 8, 7, 6, 3, 10 };
        int count = values.Length;

        for (int i = 0; i < count - 1; i++)
        {
            for (int j = i + 1; j < count; j++)
            {
                if (values[i] > values[j])
                {
                    // สลับค่าถ้าค่าที่ i มากกว่าค่าที่ j
                    int temp = values[i];
                    values[i] = values[j];
                    values[j] = temp;
                }
            }
        }

        foreach (int value in values)
        {
            Console.Write(value + " ");
        }
    }
}

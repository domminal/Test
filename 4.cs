using System;

class Program
{
    static void Main()
    {
        int input = 5;
        for (int i = 1; i <= input; i++)
        {
            Console.Write(new string(' ', input - i)); // สร้างช่องว่างด้านหน้า
            for (int j = 1; j <= 2 * i - 1; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine(); // ขึ้นบรรทัดใหม่หลังจากพิมพ์ดาวเสร็จ
        }
    }
}

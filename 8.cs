using System;

class Program
{
    static void Main()
    {
        decimal input = 1;
        decimal money = 1000 - input;

        if (input == 1000)
        {
            Console.WriteLine("ไม่มีเงินทอน");
        }
        else if (input > 1000)
        {
            Console.WriteLine("Error");
        }
        else
        {
            if (money >= 1000)
            {
                int sum1 = (int)(money / 1000);
                int sum1s = sum1 * 1000;
                money -= sum1s;
                Console.WriteLine($"ธนบัตร 1,000 = {sum1} ใบ");
            }
            if (money >= 500)
            {
                int sum2 = (int)(money / 500);
                int sum2s = sum2 * 500;
                money -= sum2s;
                Console.WriteLine($"ธนบัตร 500 = {sum2} ใบ");
            }
            if (money >= 100)
            {
                int sum3 = (int)(money / 100);
                int sum3s = sum3 * 100;
                money -= sum3s;
                Console.WriteLine($"ธนบัตร 100 = {sum3} ใบ");
            }
            if (money >= 50)
            {
                int sum4 = (int)(money / 50);
                int sum4s = sum4 * 50;
                money -= sum4s;
                Console.WriteLine($"ธนบัตร 50 = {sum4} ใบ");
            }
            if (money >= 20)
            {
                int sum5 = (int)(money / 20);
                int sum5s = sum5 * 20;
                money -= sum5s;
                Console.WriteLine($"ธนบัตร 20 = {sum5} ใบ");
            }
            if (money >= 10)
            {
                int sum51 = (int)(money / 10);
                int sum51s = sum51 * 10;
                money -= sum51s;
                Console.WriteLine($"เหรียญ 10 = {sum51} เหรียญ");
            }
            if (money >= 5)
            {
                int sum6 = (int)(money / 5);
                int sum6s = sum6 * 5;
                money -= sum6s;
                Console.WriteLine($"เหรียญ 5 = {sum6} เหรียญ");
            }
            if (money >= 2)
            {
                int sum7 = (int)(money / 2);
                int sum7s = sum7 * 2;
                money -= sum7s;
                Console.WriteLine($"เหรียญ 2 = {sum7} เหรียญ");
            }
            if (money >= 1)
            {
                int sum8 = (int)money;
                int sum8s = sum8;
                money -= sum8s;
                Console.WriteLine($"เหรียญ 1 = {sum8} เหรียญ");
            }
            if (money >= 0.75m)
            {
                Console.WriteLine("เหรียญ 0.75 = 1 เหรียญ");
                money -= 0.75m;
            }
            if (money >= 0.50m)
            {
                Console.WriteLine("เหรียญ 0.50 = 1 เหรียญ");
                money -= 0.50m;
            }
        }
    }
}

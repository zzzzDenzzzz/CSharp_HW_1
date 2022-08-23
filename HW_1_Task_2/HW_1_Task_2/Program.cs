using System;

namespace HW_1_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            double number = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите процент: ");
            int percent = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{percent} % от {number} = {(number * percent / 100)}");
        }
    }
}

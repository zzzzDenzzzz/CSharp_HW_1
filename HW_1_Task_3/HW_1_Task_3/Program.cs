using System;

namespace HW_1_Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = "";
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Введите цифру: ");
                number += Console.ReadLine();
            }
            Console.WriteLine(Convert.ToInt32(number));
        }
    }
}

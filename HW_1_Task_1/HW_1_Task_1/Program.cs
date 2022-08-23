using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_1_Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число от 1 до 100: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number >= 1 && number <= 100)
            {
                if (number % 3 == 0 && number % 5 == 0)
                {
                    Console.WriteLine("Fizz Buzz");
                }
                else if (number % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (number % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine($"Вы ввели {number}");
                }
            }
            else
            {
                Console.WriteLine("Ошибка ввода");
            }
        }
    }
}

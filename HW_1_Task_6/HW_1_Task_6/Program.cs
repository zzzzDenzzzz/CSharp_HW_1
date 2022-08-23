using System;

namespace HW_1_Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выбирите единицу измерения температуры c - Цельсий f - Фарингейт: ");
            string input = Console.ReadLine();
            if (input != "c" && input != "f")
            {
                Console.WriteLine("Ошибка ввода!");
            }
            else
            {
                Console.Write("Введите температуру: ");
                double t = Convert.ToDouble(Console.ReadLine());
                double tC = (5.0 / 9.0 * (t - 32));
                double tF = (9.0 / 5.0 * t + 32);

                switch (input)
                {
                    case "c":
                        Console.WriteLine(t.ToString() + " = " + tC + " по Цельсию");
                        break;
                    case "f":
                        Console.WriteLine(t.ToString() + " = " + tF + " по Фарингейту");
                        break;
                }
            }
        }
    }
}

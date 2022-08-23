using System;

namespace HW_1_Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите дату(дд.мм.гггг): ");
            DateTime dt = DateTime.Parse(Console.ReadLine());
            string season;
            switch (dt.Month)
            {
                case 1:
                case 2:
                case 12:
                    season = "Winter ";
                    Console.WriteLine(season + dt.DayOfWeek);
                    break;
                case 3:
                case 4:
                case 5:
                    season = "Spring ";
                    Console.WriteLine(season + dt.DayOfWeek);
                    break;
                case 6:
                case 7:
                case 8:
                    season = "Summer ";
                    Console.WriteLine(season + dt.DayOfWeek);
                    break;
                case 9:
                case 10:
                case 11:
                    season = "Autumn ";
                    Console.WriteLine(season + dt.DayOfWeek);
                    break;
                default:
                    break;
            }
        }
    }
}

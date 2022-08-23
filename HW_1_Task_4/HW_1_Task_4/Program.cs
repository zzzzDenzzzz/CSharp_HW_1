using System;

namespace HW_1_Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите 6-ти значное число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number < 99999 || number > 1000000)
            {
                Console.WriteLine("Вы ввели не 6-ти значное число!");
            }
            else
            {
                Console.Write("Введите номер разряда для обмена: ");
                int rank1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите номер разряда для обмена: ");
                int rank2 = Convert.ToInt32(Console.ReadLine());

                if ((rank1 > 0 && rank1 < 7) && (rank2 > 0 && rank2 < 7))
                {
                    string s = number.ToString();
                    char[] c = s.ToCharArray();
                    char tmp = c[rank1 - 1];
                    c[rank1 - 1] = c[rank2 - 1];
                    c[rank2 - 1] = tmp;
                    string ss = new string(c);
                    Console.WriteLine(number = Convert.ToInt32(ss));
                }
                else
                {
                    Console.WriteLine("Ошибка ввода разрядов!");
                }
            }
        }
    }
}

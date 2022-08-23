using System;

namespace HW_1_Task_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? n1 = null;
            int? n2 = null;
            for (int i = 0; i < 2; i++)
            {
                Console.Write("Введите число: ");
                int n = Convert.ToInt32(Console.ReadLine());
                if (n1 == null)
                {
                    n1 = n;
                }
                else if (n2 == null)
                {
                    n2 = n;
                }
            }
            int max = (int)((n1 > n2) ? n1 : n2);
            int min = (int)((n1 < n2) ? n1 : n2);

            for (int i = min + 1; i < max; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}

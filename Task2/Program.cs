using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int sum = 0;
            int minus = 0;
            int plus = 0;
            int count = 0;

            do
            {
                int countCycle = Convert.ToInt32(Console.ReadLine());
                count = countCycle;
                sum += countCycle;
                if (countCycle < 0)
                {
                    minus++;
                }
                else
                { 
                    plus++;
                }
                if (countCycle == 0)
                {
                    plus--;
                }
            }
            while (count!=0);

            Console.Write("Сумма = ");
            Console.WriteLine(sum);
            Console.Write("Отрицательных чисел = ");
            Console.WriteLine(minus);
            Console.Write("Положительных чисел = ");
            Console.WriteLine(plus);
            if (minus > plus)
            {
                Console.WriteLine("Отрицательных чисел больше!");
            }
            else
            {
                Console.WriteLine("Положительных чисел больше!");
            }
            Console.ReadKey();
        }
    }
}

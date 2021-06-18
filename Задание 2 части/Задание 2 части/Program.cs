using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2_части
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Дано трехзначное число. Верно ли, что все его цифры одинаковые?
            Console.Write("Введите число : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int a = n / 100;
            int c = n % 10;
            int b = n % 100 / 10;
            if (a == b && b == c)
            {
                Console.WriteLine("Цифры трехзначного числа одинаковые");
            }
            else
            {
                Console.WriteLine("Цифры трехзначного числа не одинаковые");
            }
            Console.ReadKey();
        }
    }
}

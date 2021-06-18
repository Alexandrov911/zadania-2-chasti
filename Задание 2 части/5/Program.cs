using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            //5.Дано натуральное трехзначное число.Выяснить является ли оно полиндромом.
            Console.Write("Введите сторону x");
            int x = Convert.ToInt32(Console.ReadLine());
            int a = x / 100;
            int c = x % 10;
            if (a == c)
            {
                Console.WriteLine("является");
            }
            else
            {
                Console.WriteLine("не является");
            }
            Console.ReadKey();
        }
    }
}

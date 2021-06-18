using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.	Дано трехзначное число. Определить, есть ли среди его цифр одинаковые.
            Console.Write("Введите число : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int a = n / 100;
            int c = n % 10;
            int b = n % 100 / 10;
            if (a == b || a == c || b == c)
            {
                Console.WriteLine("Yes man you cool");
            }
            else
            {
                Console.WriteLine("No, maybe i love you.");
            }
            Console.ReadKey();
        }
    }
}

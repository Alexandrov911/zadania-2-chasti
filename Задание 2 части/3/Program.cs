using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3.	Определить, является ли треугольник со сторонами a, b, c равносторонним.
            Console.WriteLine("Введите число a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число c");
            int c = Convert.ToInt32(Console.ReadLine());
            if (a == b || b == c || c == a)
            {
                Console.WriteLine("является");
            }
            else
            {
                Console.WriteLine(" не является");
            }
            Console.ReadKey();
        }
    }
}

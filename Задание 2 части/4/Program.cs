using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4.	Определить, является ли треугольник со сторонами a, b, c равнобедренным.
            //4.Определить, является ли треугольник
            // со сторонами a, b, c равнобедренным.
            Console.Write("Введите сторону a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите сторону b");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите сторону c");
            double c = Convert.ToDouble(Console.ReadLine());
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
           // 6.Составить программу, которая в зависимости от порядкового номера дня недели(1, 2, ..., 7)
           //выводит на экран его название(понедельник, вторник, ..., воскресенье).
            Console.WriteLine("месяц");
            int x = Convert.ToInt32(Console.ReadLine());
            switch (x)
            {
                case 1:
                    {
                        Console.WriteLine("Понедельник");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Вторник");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Среда");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Четверг");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Пятница");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Суббота");
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("Воскресенье");
                        break;
                    }
               
                default:
                    {
                        Console.WriteLine("error"); break;

                    }
            }
            Console.ReadKey();
        }
    }
}

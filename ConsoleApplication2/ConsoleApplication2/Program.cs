using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение радиуса");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение x");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение y");
            double y = Convert.ToDouble(Console.ReadLine());
            if (x >= -r && x <= 0 && y <= -Math.Sqrt(Math.Pow(r, 2) - Math.Pow(x + r, 2)) + r && y >= 0)
                Console.WriteLine("Точка принадлежит области");
            else if (x >= 0 && x <= r && y >= -Math.Sqrt(Math.Pow(r, 2) - Math.Pow(x, 2)) && y <= 0)
                Console.WriteLine("Точка принадлежит области");
            else
                Console.WriteLine("Точка не принадлежит области");
            Console.ReadKey();
        }
    }
}

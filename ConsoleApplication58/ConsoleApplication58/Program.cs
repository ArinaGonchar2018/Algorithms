using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication58
{
    class Program
    {
        static void Main(string[] args)
        {
            double y = 0;
            Console.WriteLine("Введите значение х");
            string X = Console.ReadLine();
            double x = Convert.ToDouble(X);
            if (x >= -7 & x < -6)
            {
                y = 1;
            }
            else if (x > -6 & x < -4)
            {
                y = -x / 2 - 2;
            }
            else if (x > -4 & x < 0)
            {
                Console.WriteLine("Введите значение R");
                string r = Console.ReadLine();
                double R = Convert.ToDouble(r);
                y = Math.Sqrt(4 - Math.Pow(x + 2, 2));
            }
            else if (x > 0 & x < 2)
            {
                Console.WriteLine("Введите значение R");
                string r = Console.ReadLine();
                double R = Convert.ToDouble(r);
                y = Math.Sqrt(1 - Math.Pow(x - 1, 2));
            }
            else if (x > 2 & x < 3)
            {
                y = -x + 2;
            }
            else if (x > 3)
            {
                Console.WriteLine("Значение находятся вне пределов интервала");
            }
            else
            {
                Console.WriteLine("Значение находятся вне пределов интервала");
            }
            Console.WriteLine("y=" + y);
            Console.ReadKey();
        }
    }
}
        

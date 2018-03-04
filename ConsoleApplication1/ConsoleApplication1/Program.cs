using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите b:");
            double b = Convert.ToDouble(Console.ReadLine());
            double z1 = (Math.Sqrt(2 * b + 2 * Math.Sqrt(Math.Pow(b, 2) - 4))) / (Math.Sqrt(Math.Pow(b, 2) - 4) + b + 2);
            Console.WriteLine("Результат:");
            Console.WriteLine("z1={0}", z1);
            double z2 = (1) / (Math.Sqrt(b + 2));
            Console.WriteLine("Результат:");
            Console.WriteLine("z2={0}", z2);
            Console.ReadKey();
        }
    }
}

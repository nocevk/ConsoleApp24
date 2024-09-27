using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                // Task1
                Console.WriteLine("Task First");
                Console.Write("Enter value x: ");
                double x = Convert.ToDouble(Console.ReadLine());

                double a = 3.4;
                double b = 2.1;

                double y;

                if (x > 1)
                {
                    y = a * Math.Exp(-b * x) * Math.Cos(Math.PI * x);
                }
                else if (x <= -1)
                {
                    y = Math.Pow((x - 5), 2) * Math.Pow(Math.Pow((x + 1), 2), 1.0 / 3);
                }
                else
                {
                    y = 0;
                }

                Console.WriteLine("Result y: " + y);
            }
        }
    }
}

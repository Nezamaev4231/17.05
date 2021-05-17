using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._87
{
    class Program
    {
        static void Main(string[] args)
        {
            //4.87
            Console.WriteLine("Введите x");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = 0;
            if (x >= 0)
            {
                y = 0;
            }
             else  if (x>0 && x<= 0)
            {
                y = x;
            }
             else
            {
                y = x * x;
            }
    

            Console.WriteLine("y=" + y);
            Console.ReadKey();
        }
    }
}

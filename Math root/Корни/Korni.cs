using System;
using System.Collections.Generic;
using System.Text;

namespace Корни
{
    class Korni
    {
        public void Ki()
        {
            double a;
            Console.WriteLine("Введите число:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Корень из " + a + " равен " + Math.Sqrt(a));
        }
    }
}

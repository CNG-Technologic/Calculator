using System;
using System.Collections.Generic;
using System.Text;

namespace _CNG__Calculator
{
    class Korni
    {
        public void Ki()
        {
            Console.WriteLine("Раздел: Корень \n");
            ifstart i = new ifstart();
            double a;
            Console.WriteLine("Введите число:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Корень из " + a + " равен " + Math.Sqrt(a));
            i.ifVstart();
        }
    }
}

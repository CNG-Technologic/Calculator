using System;
using System.Collections.Generic;
using System.Text;

namespace _CNG__Calculator
{
    class Fack
    {
        public void Fukich()
        {
            Console.WriteLine("Раздел: Факториал \n");
            ifstart i = new ifstart();
            double a;
            double F = 1;
            Console.Write("Введите число: ");
            a = Convert.ToDouble(Console.ReadLine());
            for (; a > 1; a--)
            {
                F = F * a;
            }
            Console.WriteLine("Факториал  = " + F);
            i.ifVstart();
        }
    }
}

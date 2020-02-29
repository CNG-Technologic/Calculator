using System;
using System.Collections.Generic;
using System.Text;

namespace Faktorial
{
    class Fack
    {
        public void Fukich()
        {
            double a;
            double F = 1;
            Console.Write("Введите число: ");
            a = Convert.ToDouble(Console.ReadLine());
            for (; a > 1; a--)
            {
                F = F * a;
            }
            Console.WriteLine("Факториал  = " + F);
        }
    }
}

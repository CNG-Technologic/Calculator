using System;
using System.Collections.Generic;
using System.Text;

namespace Синусы_Косинусы_Тангенсы_Котангенсы
{
    class Trig
    {
        public void Sinusi()
        {
            double a;
            Console.WriteLine("Введите число:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Math.Sin(a / 180D) * Math.PI);
        }
        public void Cosinusi()
        {
            double a;
            Console.WriteLine("Введите число:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Math.Cos(a / 180D) * Math.PI);
        }
        public void Tangensi()
        {
            double a;
            Console.WriteLine("Введите число:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Math.Tan(a / 180D) * Math.PI);
        }
        public void Cotangensi()
        {
            double a;
            Console.WriteLine("Введите число:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Math.Tanh(a / 180D) * Math.PI);
        }
    }
}

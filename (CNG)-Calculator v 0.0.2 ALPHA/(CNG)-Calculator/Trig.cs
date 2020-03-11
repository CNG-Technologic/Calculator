using System;
using System.Collections.Generic;
using System.Text;

namespace _CNG__Calculator
{
    class Trig
    {
        ifstart i = new ifstart();
        public void Sinusi()
        {
            double a;
            Console.WriteLine("Введите число:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Синус " + a + "=" + Math.Sin(a / 180D) * Math.PI);
            i.ifVstart();
        }
        public void Cosinusi()
        {
            double a;
            Console.WriteLine("Введите число:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Косинус " + a + "=" + Math.Cos(a / 180D) * Math.PI);
            i.ifVstart();
        }
        public void Tangensi()
        {
            double a;
            Console.WriteLine("Введите число:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Тангенс " + a + "=" + Math.Tan(a / 180D) * Math.PI);
            i.ifVstart();
        }
        public void Cotangensi()
        {
            double a;
            Console.WriteLine("Введите число:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Котангенс " + a + "=" + Math.Tanh(a / 180D) * Math.PI);
            i.ifVstart();
        }
    }
}

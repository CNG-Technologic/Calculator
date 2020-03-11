using System;
using System.Collections.Generic;
using System.Text;

namespace _CNG__Calculator
{
    class Ris
    {
        public void Gipo()
        {
            ifstart i = new ifstart();
            double a, b, c;
            Console.Write("Введите первый катет: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второй катет: ");
            b = Convert.ToDouble(Console.ReadLine());
            c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            if (a + b > c)
            {
                Console.WriteLine("Гипотенуза равна " + c);
                i.ifVstart();
            }
            else
            {
                Console.WriteLine("Такого треугольника не существует");
                i.ifVstart();
            }
        }
        public void Kat()
        {
            ifstart i = new ifstart();
            double a, b, c;
            Console.Write("Введите катет: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите гипотенузу: ");
            c = Convert.ToDouble(Console.ReadLine());
            b = Math.Sqrt(Math.Pow(c, 2) - Math.Pow(a, 2));
            if (a + c > b)
            {
                Console.WriteLine("Второй катет равен " + b);
                i.ifVstart();
            }
            else
            {
                Console.WriteLine("Такого треугольника не существует");
                i.ifVstart();
            }
        }
    }
}

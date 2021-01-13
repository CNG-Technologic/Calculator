using System;

namespace _CNG__Calculator
{
    class Trig
    {
        ifstart ifstart = new ifstart();
        public void Sinusi()
        {
            Console.WriteLine("Раздел: Синусы \n");
            double a;
            Console.WriteLine("Введите число:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Синус " + a + "=" + Math.Sin(a / 180D) * Math.PI);
            ifstart.ifVstart();
        }
        public void Cosinusi()
        {
            Console.WriteLine("Раздел: Косинусы \n");
            double a;
            Console.WriteLine("Введите число:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Косинус " + a + "=" + Math.Cos(a / 180D) * Math.PI);
            ifstart.ifVstart();
        }
        public void Tangensi()
        {
            Console.WriteLine("Раздел: Тангенсы \n");
            double a;
            Console.WriteLine("Введите число:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Тангенс " + a + "=" + Math.Tan(a / 180D) * Math.PI);
            ifstart.ifVstart();
        }
        public void Cotangensi()
        {
            Console.WriteLine("Раздел: Котангенсы \n");
            double a;
            Console.WriteLine("Введите число:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Котангенс " + a + "=" + Math.Tanh(a / 180D) * Math.PI);
            ifstart.ifVstart();
        }
    }
}

using System;
namespace _CNG__Calculator
{
    public class basic
    {
        static MainStart str = new MainStart();

        public void sloz(double a, double b)
        {
            Console.WriteLine(a + " + " + b + " = " + (a + b));
            str.startM();
        }

        public void vichitanie(double a, double b)
        {
            Console.WriteLine(a + " - " + b + " = " + (a - b));
            str.startM();
        }

        public void umnozhenie(double a, double b)
        {
            Console.WriteLine(a + " * " + b + " = " + (a * b));
            str.startM();
        }

        public void delenie(double a, double b)
        {
            Console.WriteLine(a + " / " + b + " = " + (a / b));
            str.startM();
        }

        public void koren(double a)
        {
            Console.WriteLine("Корень из " + a + " = " + Math.Sqrt(a));
            str.startM();
        }

        public void stepen(double a, double b)
        {
            Console.WriteLine(a + " в степени " + b + " = " + Math.Pow(a, b));
            str.startM();
        }
    }
}

using System;

namespace Calculator
{
    public class basic
    {
        public void slozheniye(double a, double b)
        {
            startMain s = new startMain();
            Console.WriteLine(a + " + " + b + " = " + (a + b));
            s.startM();
        }

        public void vychitaniye(double a, double b)
        {
            startMain s = new startMain();
            Console.WriteLine(a + " - " + b + " = " + (a - b));
            s.startM();
        }

        public void deleniye(double a, double b)
        {
            startMain s = new startMain();
            Console.WriteLine(a + " / " + b + " = " + (a / b));
            s.startM();
        }

        public void umnozheniye(double a, double b)
        {
            startMain s = new startMain();
            Console.WriteLine(a + " * " + b + " = " + (a * b));
            s.startM();
        }


    }
}

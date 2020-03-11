using System;
using System.Collections.Generic;
using System.Text;

namespace _CNG__Calculator
{
    class basic
    {
        public void slozheniye(double a, double b)
        {
            ifstart i = new ifstart();
            Console.WriteLine(a + " + " + b + " = " + (a + b));
            i.ifVstart();
        }

        public void vychitaniye(double a, double b)
        {
            ifstart i = new ifstart();
            Console.WriteLine(a + " - " + b + " = " + (a - b));
            i.ifVstart();
        }

        public void deleniye(double a, double b)
        {
            ifstart i = new ifstart();
            Console.WriteLine(a + " / " + b + " = " + (a / b));
            i.ifVstart();
        }

        public void umnozheniye(double a, double b)
        {
            ifstart i = new ifstart();
            Console.WriteLine(a + " * " + b + " = " + (a * b));
            i.ifVstart();
        }

    }
}

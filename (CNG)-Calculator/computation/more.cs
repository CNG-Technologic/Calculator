using System;
namespace _CNG__Calculator
{

    public class more
    {
        public void full_quadratic_equation(double a, double b, double c)
        {
            double D = b * b - 4 * a * c;
            Console.WriteLine("D = " + b + " * " + b + " - " + 4 + " * " + a + " * " + c + " = " + D);

            if (D > 0)
            {
                double x1 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("x1 = " + -b + " - " + Math.Sqrt(D) + " / (2 * " + a + ") = " + x1);

                double x2 = (-b + Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("x2 = " + -b + " + " + Math.Sqrt(D) + " / (2 * " + a + ") = " + x2);

            }
            else if (D == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("Уравнение имеет единственный корень: x = " + -b + " / (2 * " + a + ") = " + x);
            }
            else
                Console.WriteLine("Уравнение не имеет действительных корней!");
            
        }

        public int Factorial(double num)
        {
            int factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }

            return factorial;
        }

    }
}

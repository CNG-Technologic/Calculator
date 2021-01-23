using System;
namespace _CNG__Calculator
{
    public class more
    {
        MainStart start = new MainStart();
        piComputation pi = new piComputation();
        Percentage percentage = new Percentage();

        public void descriminant(double a, double b, double c)
        {
            double D = b * b - 4 * a * c;
            Console.WriteLine("D = " + b + " * " + b + " - " + 4 + " * " + a + " * " + c + " = " + D);

            if (D > 0)
            {
                double x1, x2;
                x1 = (-b - Math.Sqrt(D)) / (2 * a);
                x2 = (-b + Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("Корни уравнения: x1 = " + x1 + ", x2 = " + x2);
            }
            else if (D == 0)
            {
                double x;
                x = -b / (2 * a);
                Console.WriteLine("Уравнение имеет единственный корень: x = " + x);
            }
            else
            {
                Console.WriteLine("Уравнение не имеет действительных корней!");
            }
            start.startM();
        }

        public void factorial(int num)
        {
            int factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }
            Console.WriteLine(num + "! = " + factorial);
            start.startM();
        }

        public void prozent(double a)
        {
            Console.WriteLine(a + " % = " + (a / 100));

            Console.WriteLine("Продолжить действия с процентами? (y/n)");
            String ifproz = Console.ReadLine();

            if (ifproz.Equals("Y") || ifproz.Equals("y"))
            {
                percentage.Prvoid(a);
            }

            if (ifproz.Equals("N") || ifproz.Equals("n"))
            {
                start.startM();
            }
        }

        public void pio()
        {
            Console.WriteLine("PI = " + Math.PI);
            Console.WriteLine("Продолжить действия с pi? (y/n)");
            String ifpi = Console.ReadLine();

            if (ifpi.Equals("Y") || ifpi.Equals("y"))
            {
                pi.Pivoid();
            }

            if (ifpi.Equals("N") || ifpi.Equals("n"))
            {
                start.startM();
            }

        }

    }
}

using System;
namespace _CNG__Calculator
{
    /*Класс в кoтором находятся дополнительные операции для вычисения более сложных задач.
     * (Квадратное уравнение, Факториал, Действия с процентами, Действия с чилом P)
     */
    public class more
    {
        MainStart start = new MainStart();
        piComputation pi = new piComputation();
        Percentage percentage = new Percentage();

        public void Descriminant(double a, double b, double c)
        {
            double D = b * b - 4 * a * c;
            Console.WriteLine("D = " + b + " * " + b + " - " + 4 + " * " + a + " * " + c + " = " + D);

            if (D > 0)
            {
                double x1 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("x1 = " + -b + " - " + Math.Sqrt(D) + " / (2 * " + a + ") = " + x1);
                //Пользователь получит сообщение: x1 = -b - D / (2 * a);
                double x2 = (-b + Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("x2 = " + -b + " + " + Math.Sqrt(D) + " / (2 * " + a + ") = " + x2);
                //Пользователь получит сообщение: x2 = -b + D / (2 * a);

            }
            else if (D == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("Уравнение имеет единственный корень: x = " + -b + " / (2 * " + a + ") = " + x);
                //Пользователь получит сообщение Уравнение имеет единственный корень: x = -b / (2 * a);

            }
            else
            {
                Console.WriteLine("Уравнение не имеет действительных корней!");
            }
            start.StartMain();
        }

        public void Factorial(int num)
        {
            int factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }
            Console.WriteLine(num + "! = " + factorial);
            start.StartMain();
        }

        public void Prozent(double a)
        {
            Console.WriteLine(a + " % = " + (a / 100));

            Console.WriteLine("Продолжить действия с процентами? (y/n)");
            string ifproz = Console.ReadLine();

            if (ifproz.Equals("Y") || ifproz.Equals("y"))
            {
                percentage.Prvoid(a);
            }

            if (ifproz.Equals("N") || ifproz.Equals("n"))
            {
                start.StartMain();
            }
        }

        public void pio()
        {
            Console.WriteLine("PI = " + Math.PI);
            Console.WriteLine("Продолжить действия с pi? (y/n)");
            string ifpi = Console.ReadLine();

            if (ifpi.Equals("Y") || ifpi.Equals("y"))
            {
                pi.Pivoid();
            }

            if (ifpi.Equals("N") || ifpi.Equals("n"))
            {
                start.StartMain();
            }

        }

    }
}

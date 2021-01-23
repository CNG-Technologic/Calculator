using System;
namespace _CNG__Calculator
{
    public class Percentage
    {
        double a_pr;
        double pr_main;

        public void Prvoid(double a)
        {
            Percentage percentage = new Percentage();
            Console.WriteLine("Что ты хочешь сделать: ");
            String praf = Console.ReadLine();
            Console.WriteLine("Введи значение: ");
            a_pr = Convert.ToDouble(Console.ReadLine());

            if (praf.Equals("+"))
                percentage.slozhenie(a, a_pr);

            if (praf.Equals("-"))
                percentage.vicitanie(a, a_pr);

            if (praf.Equals("*"))
                percentage.umnozhenie(a, a_pr);

            if (praf.Equals("/"))
                percentage.delenie(a, a_pr);

            if (praf.Equals("s"))
                percentage.stepen(a, a_pr);

        }

        public void slozhenie(double a, double a_pr)
        {
            more more = new more();
            Console.WriteLine((a / 100) + " + " + a_pr + " = " + ((a / 100) + a_pr));
            more.prozent(a);
        }

        public void vicitanie(double a, double a_pr)
        {
            more more = new more();
            Console.WriteLine("a)" + (a / 100) + " - " + a_pr + "?" +
                    "\nb)" + a_pr + " - " + (a / 100) + "?");

            pr_main = a / 100;

            String if_proz = Console.ReadLine();
            if (if_proz.Equals("a"))
            {
                Console.WriteLine(pr_main + " - " + a_pr + " = " + (pr_main - a_pr));
            }

            if (if_proz.Equals("b"))
            {
                Console.WriteLine(a_pr + " - " + pr_main + " = " + (a_pr - pr_main));
            }
            more.prozent(a);
        }

        public void delenie(double a, double a_pr)
        {
            more more = new more();
            Console.WriteLine("a)" + (a / 100) + " / " + a_pr + "?" +
                    "\nb)" + a_pr + " / " + (a / 100) + "?");

            pr_main = a / 100;

            String if_proz = Console.ReadLine();
            if (if_proz.Equals("a"))
            {
                Console.WriteLine(pr_main + " / " + a_pr + " = " + (pr_main / a_pr));
            }

            if (if_proz.Equals("b"))
            {
                Console.WriteLine(a_pr + " / " + pr_main + " = " + (a_pr / pr_main));
            }
            more.prozent(a);
        }

        public void umnozhenie(double a, double a_pr)
        {
            more more = new more();
            Console.WriteLine((a / 100) + " * " + a_pr + " = " + ((a / 100) * a_pr));
            more.prozent(a);
        }

        public void stepen(double a, double a_pr)
        {
            more more = new more();
            Console.WriteLine(a / 100 + " в степени " + a_pr + " = " + Math.Pow(a / 100, a_pr));
            more.prozent(a);
        }

    }
}

using System;
namespace _CNG__Calculator
{
    public class piComputation
    {
        double a_pi;

        public void Pivoid()
        {
            piComputation startPI = new piComputation();
            Console.WriteLine("Что ты хочешь сделать: ");
            String piaf = Console.ReadLine();
            Console.WriteLine("Введи значение: ");
            a_pi = Convert.ToDouble(Console.ReadLine());

            if (piaf.Equals("+"))
                startPI.slozhenie(a_pi);

            if (piaf.Equals("-"))
                startPI.vicitanie(a_pi);

            if (piaf.Equals("/"))
                startPI.delenie(a_pi);

            if (piaf.Equals("*"))
                startPI.umnozhenie(a_pi);

            if (piaf.Equals("s"))
                startPI.stepenpi(a_pi);

        }

        public void slozhenie(double a_pi)
        {
            more more = new more();
            Console.WriteLine(Math.PI + " + " + a_pi + " = " + (Math.PI + a_pi));
            more.pio();
        }

        public void umnozhenie(double a_pi)
        {
            more more = new more();
            Console.WriteLine(Math.PI + " * " + a_pi + " = " + (Math.PI * a_pi));
            more.pio();
        }


        public void vicitanie(double a_pi)
        {
            more more = new more();
            Console.WriteLine("a)" + Math.PI + " - " + a_pi + "?" +
                    "\nb)" + a_pi + " - " + Math.PI + "?");
            String if_znach = Console.ReadLine();

            if (if_znach.Equals("a"))
            {
                Console.WriteLine(Math.PI + " - " + a_pi + " = " + (Math.PI - a_pi));
            }

            if (if_znach.Equals("b"))
            {
                Console.WriteLine(a_pi + " - " + Math.PI + " = " + (a_pi - Math.PI));
            }
            more.pio();
        }

        public void delenie(double a_pi)
        {
            more more = new more();
            Console.WriteLine("a)" + Math.PI + " / " + a_pi + "?" +
                    "\nb)" + a_pi + " / " + Math.PI + "?");
            String if_znachdel = Console.ReadLine();

            if (if_znachdel.Equals("a"))
            {
                Console.WriteLine(Math.PI + " / " + a_pi + " = " + (Math.PI / a_pi));
            }

            if (if_znachdel.Equals("b"))
            {
                Console.WriteLine(a_pi + " / " + Math.PI + " = " + (a_pi / Math.PI));
            }
            more.pio();
        }

        public void stepenpi(double a_pi)
        {
            more more = new more();
            Console.WriteLine(Math.PI + " в сепени " + a_pi + " = " + Math.Pow(Math.PI, a_pi));
            more.pio();
        }
    }
}

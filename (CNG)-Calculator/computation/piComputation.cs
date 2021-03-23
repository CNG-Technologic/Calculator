using System;
namespace _CNG__Calculator
{
    public class piComputation
    {

        public void pi_void()
        {

            double a;
            data data = new data();
            basic basic = new basic();
            MainStart start = new MainStart();

            Console.WriteLine("Что ты хочешь сделать: ");
            string Operator = Console.ReadLine();

            if (Operator.Equals("+") | Operator.Equals("-") | Operator.Equals("*")
                | Operator.Equals("/") | Operator.Equals("s") | Operator.Equals("?")) {

                if (Operator.Equals("+"))
                {
                    a = get_data();
                    Console.WriteLine(Math.PI + " + " + a + " = " + basic.sum(Math.PI, a));
                }

                if (Operator.Equals("-"))
                {
                    a = get_data();
                    Console.WriteLine(Math.PI + " - " + a + " = " + basic.difference(Math.PI, a));
                }

                if (Operator.Equals("*"))
                {
                    a = get_data();
                    Console.WriteLine(Math.PI + " * " + a + " = " + basic.multiplication_of_numbers(Math.PI, a));
                }

                if (Operator.Equals("/"))
                {
                    a = get_data();
                    Console.WriteLine(Math.PI + " / " + a + " = " + basic.quotient(Math.PI, a));
                }

                if (Operator.Equals("s"))
                {
                    a = get_data();
                    Console.WriteLine(Math.PI + "в степени " + a + basic.degree_num(Math.PI, a));
                }

                if (Operator.Equals("?"))
                {
                    data.help_pi_text();
                    pi_void();
                }

                start.pi_start();

            }
            else
            {
                Console.WriteLine("Команда <" + Operator + "> для работы с числом пи не найдена");
                pi_void();
            }

        }

        public double get_data()
        {
            Console.Write("Введи число: ");
            double a = Convert.ToDouble(Console.ReadLine());
            return a;
        }
    }
}

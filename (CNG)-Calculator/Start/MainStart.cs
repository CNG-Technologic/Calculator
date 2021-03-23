using System;
namespace _CNG__Calculator
{
    public class MainStart
    {

        public void StartMain()
        {
            double a, b, c;

            basic basic = new basic();
            more more = new more();
            data data = new data();

            MainProgramm mainProgramm = new MainProgramm();

            Console.WriteLine("\n(help - все функции) \nЧто ты хочешь сделать:");
            string StartOperator = Console.ReadLine();

            if (ValidateOperator(StartOperator))
            {

                if(StartOperator.Equals("+") | StartOperator.Equals("-") | StartOperator.Equals("*") | StartOperator.Equals("/"))
                {
                    Console.Write("Введи 1 число: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введи 2 число: ");
                    b = Convert.ToDouble(Console.ReadLine());

                    if (StartOperator.Equals("+"))
                        Console.WriteLine(a + " + " + b + " = " + basic.sum(a, b));

                    if (StartOperator.Equals("-"))
                        Console.WriteLine(a + " - " + b + " = " + basic.difference(a, b));

                    if (StartOperator.Equals("*"))
                        Console.WriteLine(a + " * " + b + " = " + basic.multiplication_of_numbers(a, b));

                    if (StartOperator.Equals("/"))
                        Console.WriteLine(a + " / " + b + " = " + basic.quotient(a, b));

                }

                if(StartOperator.Equals("k"))
                {
                    Console.Write("Введи число: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(basic.root_of_number(a));
                }

                if(StartOperator.Equals("s"))
                {
                    Console.Write("Введи число: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введи степень: ");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(basic.degree_num(a, b));
                }

                if(StartOperator.Equals("d"))
                {
                    Console.Write("Введи a: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введи b: ");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введи c: ");
                    c = Convert.ToDouble(Console.ReadLine());
                    more.full_quadratic_equation(a, b, c);
                }

                if(StartOperator.Equals("f") | StartOperator.Equals("!"))
                {
                    Console.Write("Введи число: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(more.Factorial(a));
                }



                if(StartOperator.Equals("?") | StartOperator.Equals("help"))
                    data.help_text();
           
                StartMain();

            } else if (StartOperator.Equals("e") | StartOperator.Equals("е"))
                mainProgramm.FullExit();
            else
            {
                Console.WriteLine("Комманда <" + StartOperator + "> не найдена");
                StartMain();
            }

        }

        public bool ValidateOperator(String Operator)
        {
            return Operator.Equals("+") | Operator.Equals("-") | Operator.Equals("*") | Operator.Equals("/") | Operator.Equals("k")
                | Operator.Equals("s") | Operator.Equals("d") | Operator.Equals("f") | Operator.Equals("!") | Operator.Equals("pi")
                | Operator.Equals("?") | Operator.Equals("help");
        }

    }
}
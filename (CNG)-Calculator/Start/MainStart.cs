using System;
namespace _CNG__Calculator
{
    public class MainStart
    {

        public void StartMain()
        {
            double a, b, c;

            basic basic = new basic();
            MainProgramm mainProgramm = new MainProgramm();

            Console.WriteLine("\n(help - все функции) \nЧто ты хочешь сделать:");
            String StartOperator = Console.ReadLine();

            if (ValidateOperator(StartOperator))
            {

                if(StartOperator.Equals("+") | StartOperator.Equals("-") | StartOperator.Equals("*") | StartOperator.Equals("/"))
                {
                    Console.Write("Введи 1 число: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введи 2 число: ");
                    b = Convert.ToDouble(Console.ReadLine());

                    if (StartOperator.Equals("+"))
                    {
                        Console.WriteLine(basic.sum(a, b));
                    }

                    if (StartOperator.Equals("-"))
                    {
                        Console.WriteLine(basic.difference(a, b));
                    }

                    if (StartOperator.Equals("*"))
                    {
                        Console.WriteLine(basic.multiplication_of_numbers(a, b));
                    }

                    if (StartOperator.Equals("/"))
                    {
                        Console.WriteLine(basic.quotient(a, b));
                    }

                }


                if (StartOperator.Equals("k"))
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

                StartMain();

            } else if(StartOperator.Equals("e") | StartOperator.Equals("е"))
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
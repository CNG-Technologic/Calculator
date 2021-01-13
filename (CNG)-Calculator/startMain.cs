using System;

namespace _CNG__Calculator
{
    class startMain
    {
        SystemStart systemStart = new SystemStart();
        Ris ris = new Ris();
        Ura ura = new Ura();
        Fack fack = new Fack();
        Trig tring = new Trig();
        Korni korni = new Korni();
        Stepeni stepeni = new Stepeni();
        ifstart start = new ifstart();
        Help help = new Help();
        basic basic = new basic();

        static double a, b, c;
        static string starerOperator;

        public void startM()
        {
            Console.WriteLine("\n Что ты хочешь сделать? \n<Help> || <?> - Увидеть возможности, \n<e> - выход: ");
            starerOperator = Console.ReadLine();

            if (starerOperator.Equals("+") || starerOperator.Equals("-") || starerOperator.Equals("*")
                || starerOperator.Equals("/") || starerOperator.Equals("1") || starerOperator.Equals("2")
                || starerOperator.Equals("3") || starerOperator.Equals("4") || starerOperator.Equals("5")
                || starerOperator.Equals("6") || starerOperator.Equals("7") || starerOperator.Equals("8")
                || starerOperator.Equals("9") || starerOperator.Equals("10") || starerOperator.Equals("?")
                || starerOperator.Equals("e"))
            {

                if (starerOperator.Equals("+") || starerOperator.Equals("-") || starerOperator.Equals("*")
                || starerOperator.Equals("/") || starerOperator.Equals("1") || starerOperator.Equals("2")
                || starerOperator.Equals("3") || starerOperator.Equals("4") || starerOperator.Equals("5")
                || starerOperator.Equals("6") || starerOperator.Equals("7") || starerOperator.Equals("8")
                || starerOperator.Equals("9") || starerOperator.Equals("10"))
                {

                    Console.WriteLine("Введи 1 число: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введи 2 число: ");
                    b = Convert.ToDouble(Console.ReadLine());

                    if (starerOperator.Equals("+"))
                        basic.slozheniye(a, b);

                    if (starerOperator.Equals("-"))
                        basic.vychitaniye(a, b);

                    if (starerOperator.Equals("*"))
                        basic.umnozheniye(a, b);

                    if (starerOperator.Equals("/"))
                        basic.deleniye(a, b);

                    if (starerOperator.Equals("1"))
                    {
                        Console.WriteLine("Раздел: Степени \n");
                        stepeni.Pow();
                    }

                    if (starerOperator.Equals("2"))
                    {
                        Console.WriteLine("Раздел: Корень \n");
                        korni.Ki();
                    }

                    if (starerOperator.Equals("3"))
                    {
                        Console.WriteLine("Раздел: Синусы \n");
                        t.Sinusi();
                    }

                    if (starerOperator.Equals("4"))
                    {
                        Console.WriteLine("Раздел: Косинусы \n");
                        t.Cosinusi();
                    }

                    if (starerOperator.Equals("5"))
                    {
                        Console.WriteLine("Раздел: Тангенсы \n");
                        t.Tangensi();
                    }

                    if (starerOperator.Equals("6"))
                    {
                        Console.WriteLine("Раздел: Котангенсы \n");
                        t.Cotangensi();
                    }

                    if (starerOperator.Equals("7"))
                    {
                        Console.WriteLine("Раздел: Факториал \n");
                        fack.Fukich();
                    }

                    if (starerOperator.Equals("8"))
                    {
                        Console.WriteLine("Раздел: Квадратное уравнение \n");
                        ura.Qua();
                    }

                    if (starerOperator.Equals("9"))
                    {
                        Console.WriteLine("Раздел: Нахождение сторон Прям.Треугольника(Теорема Пифагора)");
                        Console.WriteLine("Чтобы найти гипотенузу по двум катетам введите <1> " +
                            "\nЧтобы найти катет по гипотенузе и другому катету введите <2>");
                        starerOperator = Console.ReadLine();

                        if (starerOperator == "1")
                            ris.Gipo();

                        if (starerOperator == "2")
                            ris.Kat();

                    }

                    if (starerOperator.Equals("10"))
                    {
                        Console.WriteLine("Раздел: Переводы чисел из разных систем счисления");
                        Console.WriteLine("");
                        systemStart.idd();
                    }

                }

                if (starerOperator.Equals("?"))
                {
                    Console.WriteLine("Раздел: Возможности \n");
                    help.Can();
                }

                if (starerOperator.Equals("e"))
                    start.End();
            }
            else
            {
                Console.WriteLine("Введено некорректное значение");
                start.ifVstart();
            }

        }

    }
}
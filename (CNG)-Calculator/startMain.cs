using System;
using System.Collections.Generic;
using System.Text;

namespace _CNG__Calculator
{
    class startMain
    {
        SystemStart s = new SystemStart();
        Ris r = new Ris();
        Ura u = new Ura();
        Fack f = new Fack();
        Trig t = new Trig();
        Korni ki = new Korni();
        Stepeni st = new Stepeni();
        ifstart start = new ifstart();
        double a, b, c;
        basic basic = new basic();
        public void startM()
        {
            Help h = new Help();
            Console.WriteLine("");
            Console.WriteLine("Что ты хочешь сделать?" +
                "\n<Help> || <?> - Увидеть возможности, " +
                "\n<e> - выход: ");
            string ifoper = Console.ReadLine();

            if (ifoper.Equals("Help") || ifoper.Equals("Помощь") | ifoper.Equals("?"))
            {
                Console.WriteLine("Раздел: Возможности");
                Console.WriteLine("");
                h.Can();
            }
            if (ifoper.Equals("e") || ifoper.Equals("е"))
            { //Английская и русская e
                start.End();
            }

            if (ifoper.Equals("+") || ifoper.Equals("-") || ifoper.Equals("*") || ifoper.Equals("/"))
            {
                Console.WriteLine("Введи 1 число: ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введи 2 число: ");
                b = Convert.ToDouble(Console.ReadLine());

                if (ifoper.Equals("+"))
                {
                    basic.slozheniye(a, b);
                }

                if (ifoper.Equals("-"))
                {
                    basic.vychitaniye(a, b);
                }

                if (ifoper.Equals("*"))
                {
                    basic.umnozheniye(a, b);
                }

                if (ifoper.Equals("/"))
                {
                    basic.deleniye(a, b);
                }
            }
            if (ifoper.Equals("1") || ifoper.Equals("Step") || ifoper.Equals("step")) //Степени
            {
                Console.WriteLine("Раздел: Степени");
                Console.WriteLine("");
                st.Pow();
            }
            if (ifoper.Equals("2") || ifoper.Equals("Ko") || ifoper.Equals("ko")) //Корень
            {
                Console.WriteLine("Раздел: Корень");
                Console.WriteLine("");
                ki.Ki();
            }

            if (ifoper.Equals("3")) //Синусы
            {
                Console.WriteLine("Раздел: Синусы");
                Console.WriteLine("");
                t.Sinusi();
            }
            if (ifoper.Equals("4")) //Косинусы
            {
                Console.WriteLine("Раздел: Косинусы");
                Console.WriteLine("");
                t.Cosinusi();
            }
            if (ifoper.Equals("5")) //Тангенсы
            {
                Console.WriteLine("Раздел: Тангенсы");
                Console.WriteLine("");
                t.Tangensi();
            }
            if (ifoper.Equals("6")) //Котангенсы
            {
                Console.WriteLine("Раздел: Котангенсы");
                Console.WriteLine("");
                t.Cotangensi();
            }
            if (ifoper.Equals("7")) //Факториал
            {
                Console.WriteLine("Раздел: Факториал");
                Console.WriteLine("");
                f.Fukich();
            }
            if (ifoper.Equals("8")) //Квадратное уравнение
            {
                Console.WriteLine("Раздел: Квадратное уравнение");
                Console.WriteLine("");
                u.Qua();
            }
            if (ifoper.Equals("9")) //Стороны Прям.Треугольника(Теорема Пифагора)
            {
                Console.WriteLine("Раздел: Нахождение сторон Прям.Треугольника(Теорема Пифагора)");
                Console.WriteLine("");
                Console.WriteLine("Чтобы найти гипотенузу по двум катетам введите <1>" +
                            "\nЧтобы найти катет по гипотенузе и другому катету введите <2>");
                ifoper = Console.ReadLine();
                if (ifoper == "1")
                {
                    r.Gipo();
                }
                if (ifoper == "2")
                {
                    r.Kat();
                }
            }
            if (ifoper.Equals("10")) //Системы Счисления
            {
                Console.WriteLine("Раздел: Переводы чисел из разных систем счисления");
                Console.WriteLine("");
                s.idd();
            }
        }
    }
}


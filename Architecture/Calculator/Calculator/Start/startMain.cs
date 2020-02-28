using System;

namespace Calculator
{
    public class startMain
    {

        ifstart start = new ifstart();
        double a, b, c;
        basic basic = new basic();
        public void startM()
        {
            Console.WriteLine("Что ты хочешь сделать(e - выход): ");
            String ifoper = Console.ReadLine();

            if (ifoper.Equals("e") || ifoper.Equals("е"))
            { //Английская и русская e
                Console.WriteLine("Вы действительно хотите выйти? ");
                start.ifVstart();
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

            //Ниже другие ифы


        }
    }
}

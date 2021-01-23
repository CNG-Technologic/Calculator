using System;
namespace _CNG__Calculator
{
    public class MainStart
    {
        public void startM()
        {
            double a, b, c;
            ifStart Mstart = new ifStart();
            Help help = new Help();
            basic basic = new basic();
            more more = new more();


            Console.WriteLine("Что ты хочешь сделать: ");
            String ifoper = Console.ReadLine();

            if (ifoper.Equals("+") || ifoper.Equals("-") || ifoper.Equals("*") || ifoper.Equals("/") || ifoper.Equals("k")
                || ifoper.Equals("s") || ifoper.Equals("d") || ifoper.Equals("f") || ifoper.Equals("!") ||
                ifoper.Equals("pi") || ifoper.Equals("sin") || ifoper.Equals("cos") || ifoper.Equals("tan") || ifoper.Equals("e")
                || ifoper.Equals("е") || ifoper.Equals("?") || ifoper.Equals("help"))
            {

                if (ifoper.Equals("e") || ifoper.Equals("е"))
                { //Английская и русская e
                    Console.WriteLine("Ты действительно хочешь выйти? ");
                    Mstart.ifStartVoid();
                }

                if (ifoper.Equals("help") || ifoper.Equals("?"))
                    help.Can();

                if (ifoper.Equals("+") || ifoper.Equals("-") || ifoper.Equals("*") || ifoper.Equals("/"))
                {
                    Console.WriteLine("Введи 1 число: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введи 2 число: ");
                    b = Convert.ToDouble(Console.ReadLine());

                    if (ifoper.Equals("+"))
                    {
                        basic.sloz(a, b);
                    }

                    if (ifoper.Equals("-"))
                    {
                        basic.vichitanie(a, b);
                    }

                    if (ifoper.Equals("*"))
                    {
                        basic.umnozhenie(a, b);
                    }

                    if (ifoper.Equals("/"))
                    {
                        basic.delenie(a, b);
                    }


                }

                if (ifoper.Equals("k"))
                {
                    Console.WriteLine("Введи число:");
                    a = Convert.ToDouble(Console.ReadLine());
                    basic.koren(a);
                }


                if (ifoper.Equals("s"))
                {
                    Console.WriteLine("Введи число: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введи степень: ");
                    b = Convert.ToDouble(Console.ReadLine());
                    basic.stepen(a, b);
                }

                if (ifoper.Equals("d"))
                {
                    Console.WriteLine("Введи a: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введи b: ");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введи c: ");
                    c = Convert.ToDouble(Console.ReadLine());
                    more.descriminant(a, b, c);
                }

                if (ifoper.Equals("f") || ifoper.Equals("!"))
                {
                    Console.WriteLine("Введи число: ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    more.factorial(num);
                }


                if (ifoper.Equals("pi"))
                    more.pio();
                

            }
            else
            {
                Console.WriteLine("Команда <" + ifoper + "> не найдена.");
                startM();
            }

        }
    }
}
using System;
namespace _CNG__Calculator
{
    //TODO: переименновать данный класс
    public class MainStart
    {
        public void startM()
        {
            //переменные для передачи объектам данных 
            double a, b, c;

            ifStart Mstart = new ifStart();

            //Объекты для запуска вычислительных операций
            Help help = new Help();
            basic basic = new basic();
            more more = new more();


            Console.WriteLine("Что ты хочешь сделать: ");
            string ifoper = Console.ReadLine();

            /* Если введеное знаечение от пользователя удовлетваряет это условие, запускается проверка для запуска конкреной операции, 
             * иначе пользователь увидит ошибку о неизвестном операторе.
             */
            if (ifoper.Equals("+") || ifoper.Equals("-") || ifoper.Equals("*") || ifoper.Equals("/") || ifoper.Equals("k")
                || ifoper.Equals("s") || ifoper.Equals("d") || ifoper.Equals("f") || ifoper.Equals("!") || ifoper.Equals("pi")
                || ifoper.Equals("e") || ifoper.Equals("е") || ifoper.Equals("?") || ifoper.Equals("help"))
            {

                if (ifoper.Equals("e") || ifoper.Equals("е"))
                { //Английская и русская e
                    Console.WriteLine("Ты действительно хочешь выйти? ");
                    Mstart.ifStartVoid();
                }

                if (ifoper.Equals("help") || ifoper.Equals("?"))
                    help.Can();

                //Это условие нужно для минимизации повтора кода. Для + - / * нужно получить на вход 2 числа
                if (ifoper.Equals("+") || ifoper.Equals("-") || ifoper.Equals("*") || ifoper.Equals("/"))
                {
                    Console.WriteLine("Введи 1 число: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введи 2 число: ");
                    b = Convert.ToDouble(Console.ReadLine());

                    if (ifoper.Equals("+"))
                        basic.sloz(a, b);

                    if (ifoper.Equals("-"))
                        basic.vichitanie(a, b);
                    
                    if (ifoper.Equals("*"))
                        basic.umnozhenie(a, b);
                    
                    if (ifoper.Equals("/"))
                        basic.delenie(a, b);
                }

                if (ifoper.Equals("k"))
                {
                    Console.WriteLine("Введи число: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    basic.koren(a);
                }

                //В этом условие на вход получаются 2 числа, но сообщение для пользователя отличается (Введи степень, а не Введи 2 число)
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
                    more.Descriminant(a, b, c);
                }

                if (ifoper.Equals("f") || ifoper.Equals("!"))
                {
                    Console.WriteLine("Введи число: ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    more.Factorial(num);
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
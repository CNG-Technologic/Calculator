using System;

namespace _CNG__Calculator
{
    class MainProgramm
    {

        static MainStart Start = new MainStart();

        static void Main(string[] args)
        {
            Console.WriteLine("Добро Пожаловать в Калькулятор (V1.2 BETA)");
            StartVoid();
        }

        public static void StartVoid() {
            Console.WriteLine("\n1 - старт \n2 - выход");

            string start_operator = Console.ReadLine();

            if (start_operator.Equals("1"))
                Start.StartMain();
            else if (start_operator.Equals("2"))
                Console.WriteLine("Завершение работы...");
            else
            {
                Console.WriteLine("Команда <" + start_operator + "> не найдена");
                StartVoid();
            }

        }

        public void FullExit()
        {
            Console.WriteLine("\nТы действительно хочешь выйти?");
            Console.WriteLine("1 - да \n2 - нет");
            String exit = Console.ReadLine();

            if (exit.Equals("2"))
            {
                Start.StartMain();
            }
            else if (exit.Equals("1"))
            {
                Console.WriteLine("Завершение работы...");
            }
            else
            {
                Console.WriteLine("Команада <" + exit + "> не найдена");
                FullExit();
            }
        }

    }
}
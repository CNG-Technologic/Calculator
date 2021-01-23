using System;

namespace _CNG__Calculator
{
    class MainProgramm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро Пожаловать в Калькулятор (V1.0 BETA)");
            ifStart start = new ifStart();
            start.Start();

            Console.WriteLine(args);

        }
    }
}
using System;

namespace _CNG__Calculator
{
    class MainProgramm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро Пожаловать в Калькулятор (V.0.0.3 ALPHA)");
            ifStart start = new ifStart();
            start.Start();
        }
    }
}

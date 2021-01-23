using System;

namespace _CNG__Calculator
{
    class Help
    {
        public void Can()
        {
            Console.WriteLine("Раздел: Возможности \n");
            Console.WriteLine("'+' - сложение " +
                "\n'-' - вычитание" +
                "\n'*' - умножение" +
                "\n'/' - деление" +
                "\n'k' - корень" +
                "\n'!' или 'f' - факториал" +
                "\n's' - степень" +
                "\n'd' - дескриминант" +
                "\n'pi' - число пи" +
                "\n'e' - выход");

            MainStart start = new MainStart();
            start.startM();

        }
    }
}

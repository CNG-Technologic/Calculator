using System;

namespace _CNG__Calculator
{
    class data
    {
        //Метод, который показывает все возможности калькулятора
        public void help_text()
        {
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
            start.StartMain();
        }

        public void help_pi_text()
        {
            Console.WriteLine("'+' - сложение " +
                "\n'-' - вычитание" +
                "\n'*' - умножение" +
                "\n'/' - деление" +
                "\n's' - степень");
        }

    }
}

using System;

namespace _CNG__Calculator
{
    class ifstart
    {
        public void ifVstart()
        {
            ifstart i = new ifstart();
            Console.WriteLine("<1>- Старт \n<2> - Выход");


            string ifstart = Console.ReadLine();
            StartMain start = new StartMain();

            if (ifstart.Equals("1") || ifstart.Equals("2"))
            {

                if (ifstart.Equals("1"))
                    start.StartM();

                if (ifstart.Equals("2"))
                    i.End();
            }
            else
            {
                Console.WriteLine("Введено некорректное значение");
                Console.WriteLine("");
                i.ifVstart();
            }
        }

        public void End()
        {
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Спасибо что воспользовались нашим калькулятором");
            Console.WriteLine("Ждите обновлений!");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class ifstart
    {

        public void ifVstart()
        {
            Console.WriteLine("1 - Страрт \n2 - Выход");
            String ifstart = Console.ReadLine();
            startMain start = new startMain();

            if (ifstart.Equals("1"))
            {
                start.startM();
            }
            else
                Console.WriteLine("Завершение работы...");
        }

    }
}

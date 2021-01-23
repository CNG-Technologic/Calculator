using System;
namespace _CNG__Calculator
{
    public class ifStart
    {
        MainStart start_1 = new MainStart();

        public void Start()
        {
            string ifstart;
            Console.WriteLine("1 - старт \n2 - выход");
            ifstart = Console.ReadLine();

            if (ifstart.Equals("1"))
                start_1.startM();
            else
                Console.WriteLine("Завершение работы...");

        }

        public void ifStartVoid()
        {
            string ifstart;
            Console.WriteLine("1 - да \n2 - нет \nТакже работет Y/N (yes/no)");
            ifstart = Console.ReadLine();

            if (ifstart.Equals("нет") || ifstart.Equals("2") || ifstart.Equals("N") || ifstart.Equals("n") || ifstart.Equals("NO")
                || ifstart.Equals("no") || ifstart.Equals("No") || ifstart.Equals("н") || ifstart.Equals("Нет"))
            {
                start_1.startM();
            }
            else
                Console.WriteLine("Завершение работы...");

        }

    }

}

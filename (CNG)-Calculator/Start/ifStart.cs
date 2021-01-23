using System;
namespace _CNG__Calculator
{
    //TODO:Переименновать данный класс 
    public class ifStart
    {
        MainStart start_1 = new MainStart();

        //Базовый метод для старта калькулятора
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

        //Метод для проверки выхода из приложения, который вызывается в случае если пользователь хочет выйти их приложения
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

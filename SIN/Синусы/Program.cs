using System;

namespace Синусы_Косинусы_Тангенсы_Котангенсы
{
    class Program
    {
        static void Main(string[] args)
        {
            Trig t = new Trig();
            string v;
            Console.WriteLine("Синусы - <1>," +
                "\nКосинусы - <2>," +
                "\nТангенсы - <3>," +
                "\nКотангенсы - <4>");
            v = Console.ReadLine();
            if (v == "1")
            {
                t.Sinusi();
            }
            if (v == "2")
            {
                t.Cosinusi();
            }
            if (v == "3")
            {
                t.Tangensi();
            }
            if (v == "4")
            {
                t.Cotangensi();
            }
            else
            {
                Console.WriteLine("Введено некорректное значение");
            }
        }
    }
}

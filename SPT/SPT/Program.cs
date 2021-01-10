using System;

namespace SPT
{
    class Program
    {
        static void Main(string[] args)
        {
            Ris r = new Ris();
            string v;
            Console.WriteLine("Чтобы найти гипотенузу по двум катетам введите <1>" +
                            "\nЧтобы найти катет по гипотенузе и другому катету введите <2>");
            v = Console.ReadLine();
            if (v == "1")
            {
                r.Gipo();
            }
            if (v == "2")
            {
                r.Kat();
            }
        }
    }
}

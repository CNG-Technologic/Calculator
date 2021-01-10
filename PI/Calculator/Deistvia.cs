using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Deistvia
    {
		public void Des()
		{
			string oper, v;
			double a;
			Console.WriteLine("Введите оператор:");
			oper = Console.ReadLine();

			Console.WriteLine("Введите число:");
			a = Convert.ToDouble(Console.ReadLine());
			if (oper == "+")
			{
				Console.WriteLine(" Cумма " + a + " и " + Math.PI + "(число Пи)  равна " + (a + Math.PI) + "."); //выводит на экран сумму
			}
			else if (oper == "-")
			{
				Console.WriteLine("Разность " + a + " на число Пи - <1>,число Пи на " + a + " - <2>");
				v = Console.ReadLine();
				if (v == "1")
				{
					Console.WriteLine(" Разность " + a + " на " + Math.PI + " (число Пи) равно " + (a - Math.PI) + "."); //выводит на экран разность
				}
				if (v == "2")
				{
					Console.WriteLine(" Разность " + Math.PI + " (число Пи) на " + a + " равно " + (Math.PI - a) + "."); //выводит на экран разность
				}
			}
			else if (oper == "*")
			{
				Console.WriteLine(" Умножение " + a + " на " + Math.PI + "(число Пи)  равно " + (a * Math.PI) + "."); //выводит на экран произведение
			}
			else if (oper == "/")
			{
				Console.WriteLine("Деление " + a + " на число Пи - <1>,число Пи на " + a + " - <2>");
				v = Console.ReadLine();
				if (v == "1")
				{
					Console.WriteLine(" Деление " + a + " на " + Math.PI + " (число Пи) равно " + (a / Math.PI) + "."); //выводит на экран деление
				}
				if (v == "2")
				{
					Console.WriteLine(" Деление " + Math.PI + " (число Пи) на " + a + " равно " + (Math.PI / a) + "."); //выводит на экран деление
				}
			}

			else
			{
				Console.WriteLine("Введено некорректное значение (Правильные значения в данном контексте: <*> </> <-> <+> )");
			}
		}
    }
}

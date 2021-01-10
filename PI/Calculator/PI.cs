using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
	class PI
	{
		public void Vid()
		{
			Deistvia d = new Deistvia();
			string flexible;
			Console.WriteLine("Число Пи = " + Math.PI);
			Console.WriteLine("Хотите вычислить что-то с числом Пи? (Да или нет)");
			flexible = Convert.ToString(Console.ReadLine());

			if (flexible.Equals("Нет") || flexible.Equals("нет") || flexible.Equals("0"))
			{
				//Тут должен начаться цикл
			}

			if (flexible.Equals("Да") || flexible.Equals("да") || flexible.Equals("1")) //Взимодействие с числом Пи
			{
				d.Des();
			}
		}
	}
}
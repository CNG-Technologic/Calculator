using System;
using System.Collections.Generic;
using System.Text;

namespace Степени
{
    class Stepeni
    {
        public void Pow()
        {
			double a, b, c;
			Console.Write("Какое число вы хотите возвести в степень? ");
			a = Convert.ToDouble(Console.ReadLine());
			Console.Write("Введите степень в которую вы хотите возвести ");
			b = Convert.ToDouble(Console.ReadLine());
			c = Math.Pow(a, b);
			if (c > 179769313486232 || c < -179769313486232)
			{
				Console.WriteLine("Число слишком длинное");
			}
			else
			{
				Console.WriteLine(c);
			}
		}
    }
}

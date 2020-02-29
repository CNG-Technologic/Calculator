using System;
using System.Collections.Generic;
using System.Text;

namespace QuadUravnenie
{
    class Ura
    {
        public void Qua()
        {
			double a, b, c, d, x1, x2;
			Console.Write("Введите а (Член квадратного уравнения стоящий перед x^2): ");
			a = Convert.ToDouble(Console.ReadLine());
			Console.Write("Введите b (Член квадратного уравнения стоящий перед x): ");
			b = Convert.ToDouble(Console.ReadLine());
			Console.Write("Введите c (Свободный член квадратного уравнения): ");
			c = Convert.ToDouble(Console.ReadLine());
			d = Math.Pow(b, 2) - 4 * a * c; //Вычисления дискриминанта
			if (d > 0)
			{
				x1 = (-1 * b + Math.Sqrt(d)) / 2 * a; //Вычисления первого корня
				x2 = (-1 * b - Math.Sqrt(d)) / 2 * a; //Вычисления второго корня
				Console.WriteLine("Дискриминант (d) равен  " + d);
				Console.WriteLine("Первый корень (x1) равен  " + x1);
				Console.WriteLine("Второй корень (x2) равен  " + x2);
			}
			if (d == 0)
			{
				x1 = (-1 * b + Math.Sqrt(d)) / 2 * a;     //X1=X2
				Console.WriteLine("Дискриминант (d) равен " + d);
				Console.WriteLine("Первый корень равен второму (x1=x2) = " + x1);
			}
			if (d < 0)
			{
				Console.WriteLine("Дискриминант (d) меньше нуля,корней нет");
			}
		}
    }
}

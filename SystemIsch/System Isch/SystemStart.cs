using System;
using System.Collections.Generic;
using System.Text;

namespace System_Isch
{
	class SystemStart
	{
		public void idd()
		{
			string flexible, v, bin, hexValue;
			long value;
			Console.WriteLine("Из какой вы хотите системы исчесления перевести число?" +
				"\n<1>-Для перевода из Hex (Шестнадцатеричной)" +
				"\n<2>-Для перевода из Dec (Десятичной)" +
				"\n<3>-Для перевода из Oct (Восьмеричной)" +
				"\n<4>-Для перевода из Bin (Двоичной)");
			flexible = Console.ReadLine();
			Console.WriteLine("В какую вы хотите систему исчесления перевести число?" +
			"\n<1>-Для перевода в Hex (Шестнадцатеричной)" +
			"\n<2>-Для перевода в Dec (Десятичной)" +
			"\n<3>-Для перевода в Oct (Восьмеричной)" +
			"\n<4>-Для перевода в Bin (Двоичной)");
			v = Console.ReadLine();
			Console.WriteLine("Введите число");
			if (flexible == "1")
			{
				if (v == "1")
				{
					bin = Console.ReadLine();
					value = Convert.ToInt32(bin, 16);
					hexValue = Convert.ToString(value, 16);
					Console.WriteLine("Число в 16-ой СС: {0}", hexValue.ToUpper());
				}
				if (v == "2")
				{
					bin = Console.ReadLine();
					value = Convert.ToInt32(bin, 16);
					hexValue = Convert.ToString(value, 10);
					Console.WriteLine("Число в 10-ой СС: {0}", hexValue.ToUpper());
				}
				if (v == "3")
				{
					bin = Console.ReadLine();
					value = Convert.ToInt32(bin, 16);
					hexValue = Convert.ToString(value, 8);
					Console.WriteLine("Число в 8-ой СС: {0}", hexValue.ToUpper());
				}
				if (v == "4")
				{
					bin = Console.ReadLine();
					value = Convert.ToInt32(bin, 16);
					hexValue = Convert.ToString(value, 2);
					Console.WriteLine("Число в 2-ой СС: {0}", hexValue.ToUpper());
				}

			}
			if (flexible == "2")
			{
				if (v == "1")
				{
					bin = Console.ReadLine();
					value = Convert.ToInt32(bin, 10);
					hexValue = Convert.ToString(value, 16);
					Console.WriteLine("Число в 16-ой СС: {0}", hexValue.ToUpper());
				}
				if (v == "2")
				{
					bin = Console.ReadLine();
					value = Convert.ToInt32(bin, 10);
					hexValue = Convert.ToString(value, 10);
					Console.WriteLine("Число в 10-ой СС: {0}", hexValue.ToUpper());
				}
				if (v == "3")
				{
					bin = Console.ReadLine();
					value = Convert.ToInt32(bin, 10);
					hexValue = Convert.ToString(value, 8);
					Console.WriteLine("Число в 8-ой СС: {0}", hexValue.ToUpper());
				}
				if (v == "4")
				{
					bin = Console.ReadLine();
					value = Convert.ToInt32(bin, 10);
					hexValue = Convert.ToString(value, 2);
					Console.WriteLine("Число в 2-ой СС: {0}", hexValue.ToUpper());
				}
			}
			if (flexible == "3")
			{
				if (v == "1")
				{
					bin = Console.ReadLine();
					value = Convert.ToInt32(bin, 8);
					hexValue = Convert.ToString(value, 16);
					Console.WriteLine("Число в 16-ой СС: {0}", hexValue.ToUpper());
				}
				if (v == "2")
				{
					bin = Console.ReadLine();
					value = Convert.ToInt32(bin, 8);
					hexValue = Convert.ToString(value, 10);
					Console.WriteLine("Число в 8-ой СС: {0}", hexValue.ToUpper());
				}
				if (v == "3")
				{
					bin = Console.ReadLine();
					value = Convert.ToInt32(bin, 8);
					hexValue = Convert.ToString(value, 8);
					Console.WriteLine("Число в 10-ой СС: {0}", hexValue.ToUpper());
				}
				if (v == "4")
				{
					bin = Console.ReadLine();
					value = Convert.ToInt32(bin, 8);
					hexValue = Convert.ToString(value, 2);
					Console.WriteLine("Число в 2-ой СС: {0}", hexValue.ToUpper());
				}

			}
			if (flexible == "4")
			{
				if (v == "1")
				{
					bin = Console.ReadLine();
					value = Convert.ToInt32(bin, 2);
					hexValue = Convert.ToString(value, 16);
					Console.WriteLine("Число в 16-ой СС: {0}", hexValue.ToUpper());
				}
				if (v == "2")
				{
					bin = Console.ReadLine();
					value = Convert.ToInt32(bin, 2);
					hexValue = Convert.ToString(value, 10);
					Console.WriteLine("Число в 10-ой СС: {0}", hexValue.ToUpper());
				}
				if (v == "3")
				{
					bin = Console.ReadLine();
					value = Convert.ToInt32(bin, 2);
					hexValue = Convert.ToString(value, 8);
					Console.WriteLine("Число в 8-ой СС: {0}", hexValue.ToUpper());
				}
				if (v == "4")
				{
					bin = Console.ReadLine();
					value = Convert.ToInt32(bin, 2);
					hexValue = Convert.ToString(value, 2);
					Console.WriteLine("Число в 2-ой СС: {0}", hexValue.ToUpper());
				}

			}
		}
	}
}

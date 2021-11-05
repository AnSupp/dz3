using System;
using static System.Console;

namespace dz3._3
{
	public class Program
	{
		public static void Main()
		{
			int n;
			bool flag = false;
			WriteLine("Введите число");
			n = int.Parse(ReadLine());
			int i = 2;
			while (i <= n - 1)
			{
				if (n % i == 0)
				{
					flag = true;
				}

				i++;
			}
			if (flag)
			{
				WriteLine("Не простое");
			}
			else
			{
				WriteLine("Простое");
			}
			ReadLine();
		}
	}
}

using System;
using static System.Console;

namespace dz3._2
{
	class Program
	{
		static void Main(string[] args)
		{
			WriteLine("Приветствую, игрок!\nВведите количество карт:");
			int n = int.Parse(ReadLine());
			int sum = 0;
			for (int i = 0; i < n; i++)
			{
				WriteLine("Укажите карту:");
				string input = ReadLine();
				switch (input)
				{
					case "J":
						sum += 10;
						break;
					case "Q":
						sum += 10;
						break;
					case "K":
						sum += 10;
						break;
					case "T":
						sum += 10;
						break;
					default:
						try
						{
							int inputNum = int.Parse(input);
							if ((inputNum >= 2) && (inputNum <= 10))
							{
								sum += inputNum;
							}
							else
							{
								WriteLine("Некорректный номер карты");
								i--;
							}
						}
						catch
						{

							WriteLine("Некорректный номер карты");
							i--;
						}
						break;
				}
			}
			WriteLine("Сумма ваших карт: " + sum);
			ReadLine();
		}
	}
}
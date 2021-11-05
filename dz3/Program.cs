using System;
using static System.Console;

namespace dz3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            WriteLine("Введите целое число:");
            n = int.Parse(ReadLine());

            if (n % 2 == 0)
                WriteLine("Число четное");
            else
                WriteLine("Число нечетное");

            ReadLine();
        }
    }
}

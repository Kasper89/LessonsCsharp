using System;
using System.Runtime.Remoting.Channels;

namespace Lesson5DZ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число: ");
            int one = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");
            int two = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите третье число: ");
            int three = int.Parse(Console.ReadLine());

            if (one > two && one>three)
            {
                Console.WriteLine(one);
            }
            else if (two >one && two > three)
            {
                Console.WriteLine(two);
            }
            else if (three > one && three> two)
            {
                Console.WriteLine(three);
            }

            switch (one % 2 == 0)
            {
                case true:
                    Console.WriteLine("Первое число четное");
                    break;
                default:
                    Console.WriteLine("Первое число не четное");
                    break;
            }

            switch (two % 2 == 0)
            {
                case true:
                    Console.WriteLine("Второе число четное");
                    break;
                default:
                    Console.WriteLine("Второе число не четное");
                    break;
            }

            switch (three % 2 == 0)
            {
                case true:
                    Console.WriteLine("Третье число четное");
                    break;
                default:
                    Console.WriteLine("Третье число не четное");
                    break;
            }

            Console.WriteLine(one <100? "Первое число меньше 100": "Первое число больше 100");

            Console.WriteLine(two < 100 ? "Второе число меньше 100" : "Второе число больше 100");

            Console.WriteLine(three < 100 ? "Третье число меньше 100" : "Третье число больше 100");


            Console.ReadLine();
        }
    }
}
